using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FAS.Core.Exceptions;

namespace FAS.Persistence
{
    public class QueryDao : IQueryDao
    {
        private readonly string _connectionString;

        public QueryDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected readonly Dictionary<string, DbType> TypeMapping = new Dictionary<string, DbType>
        {
            { nameof(Int16), DbType.Int16 },
            { nameof(Int32), DbType.Int32 },
            { nameof(Int64), DbType.Int64 },
            { nameof(Decimal), DbType.Decimal },
            { nameof(String), DbType.String},
            { nameof(DateTime), DbType.DateTime},
            { typeof(byte[]).Name , DbType.Binary }
        };

        public Task<T> GetAsync<T>(object id) where T : IQueryable
        {
            var tableNameAttribute = (TableNameAttribute)typeof(T).GetCustomAttributes().FirstOrDefault(attr => attr is TableNameAttribute);
            if (tableNameAttribute == null)
                throw new Exception("Specify table name");

            var properties = typeof(T).GetProperties();
            var pkProperty = properties.FirstOrDefault(prop => prop.GetCustomAttributes().Any(att => att is PkAttribute));
            if (pkProperty == null)
                throw new Exception("Specify pk");

            var hasType = TypeMapping.TryGetValue(pkProperty.PropertyType.Name, out var pkDbType);
            if (!hasType)
                throw new NotSupportedException($"Can't work with type {pkProperty.PropertyType.Name}");

            return GetAsync<T>((pkProperty.Name, pkDbType, id), tableNameAttribute.Name);
        }

        public Task<List<T>> ListAsync<T>(string where = null) where T : IQueryable
        {
            var tableNameAttribute = (TableNameAttribute)typeof(T).GetCustomAttributes().FirstOrDefault(attr => attr is TableNameAttribute);
            if (tableNameAttribute == null)
                throw new Exception("Specify table name");

            return ListAsync<T>(tableNameAttribute.Name, where);
        }

        protected async Task<T> GetAsync<T>((string name, DbType type, object value) id, string tableName)
        {
            var propertyNames = new List<string>();
            var properties = typeof(T).GetProperties();

            foreach (var property in typeof(T).GetProperties())
            {
                if (!TypeMapping.ContainsKey(property.PropertyType.Name))
                    throw new NotSupportedException($"Can't work with type {property.PropertyType.Name}");

                propertyNames.Add($"[{property.Name}]");
            }

            var sql = $@"SELECT {string.Join(",", propertyNames)} FROM {tableName} WHERE {id.name} = @Id";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Id",
                        DbType = id.type,
                        Value = id.value
                    });

                    await conn.OpenAsync();
                    var reader = await cmd.ExecuteReaderAsync();
                    if (!reader.HasRows)
                        throw new ObjectNotFoundException(id.ToString(), typeof(T));

                    await reader.ReadAsync();

                    return CreateInstance<T>(reader, properties);
                }
            }
        }

        private async Task<List<T>> ListAsync<T>(string tableName, string where)
        {
            var propertyNames = new List<string>();
            var properties = typeof(T).GetProperties();
            foreach (var property in typeof(T).GetProperties())
            {
                if (!TypeMapping.ContainsKey(property.PropertyType.Name))
                    throw new NotSupportedException($"Can't store type {property.PropertyType.Name}");

                propertyNames.Add($"[{property.Name}]");
            }

            var sql = $@"SELECT {string.Join(",", propertyNames)} FROM {tableName}";
            if (!string.IsNullOrWhiteSpace(where))
                sql += $" WHERE {where}";

            var result = new List<T>();
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    await conn.OpenAsync();
                    var reader = await cmd.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        result.Add(CreateInstance<T>(reader, properties));
                    }
                }
            }

            return result;
        }

        private T CreateInstance<T>(IDataRecord record, IEnumerable<PropertyInfo> properties)
        {
            var instance = Activator.CreateInstance<T>();
            foreach (var property in properties)
            {
                var dbType = TypeMapping[property.PropertyType.Name];

                var dbNull = record[property.Name] is DBNull;

                if (dbNull && property.PropertyType.IsClass)
                    continue;

                if (dbNull && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    throw new Exception("Can't assign null to not nullable property");

                var ordinal = record.GetOrdinal(property.Name);

                switch (dbType)
                {
                    case DbType.Int16:
                        property.SetValue(instance, record.GetInt16(ordinal));
                        break;
                    case DbType.Int32:
                        property.SetValue(instance, record.GetInt32(ordinal));
                        break;
                    case DbType.Int64:
                        property.SetValue(instance, record.GetInt64(ordinal));
                        break;
                    case DbType.Decimal:
                        property.SetValue(instance, record.GetDecimal(ordinal));
                        break;
                    case DbType.String:
                        property.SetValue(instance, record.GetString(ordinal));
                        break;
                    case DbType.DateTime:
                        property.SetValue(instance, record.GetDateTime(ordinal));
                        break;
                    case DbType.Binary:
                        property.SetValue(instance, (byte[])record.GetValue(ordinal));
                        break;
                    default:
                        throw new Exception($"Processing type {property.PropertyType} is unsupported");
                }
            }

            return instance;
        }
    }
}
