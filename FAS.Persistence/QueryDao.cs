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

        protected readonly Dictionary<Type, DbType> TypeMapping = new Dictionary<Type, DbType>
        {
            { typeof(short), DbType.Int16 },
            { typeof(int), DbType.Int32 },
            { typeof(long), DbType.Int64 },
            { typeof(decimal), DbType.Decimal },
            { typeof(string), DbType.String},
            { typeof(Enum), DbType.String},
            { typeof(DateTime), DbType.DateTime},
            { typeof(DateTime?), DbType.DateTime},
            { typeof(byte[]) , DbType.Binary }
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

            var hasType = TypeMapping.TryGetValue(pkProperty.PropertyType, out var pkDbType);
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

        public List<T> List<T>(string where = null) where T : IQueryable
        {
            var tableNameAttribute = (TableNameAttribute)typeof(T).GetCustomAttributes().FirstOrDefault(attr => attr is TableNameAttribute);
            if (tableNameAttribute == null)
                throw new Exception("Specify table name");

            return List<T>(tableNameAttribute.Name, where);
        }

        protected async Task<T> GetAsync<T>((string name, DbType type, object value) id, string tableName)
        {
            var propertyNames = new List<string>();
            var properties = typeof(T).GetProperties();

            foreach (var property in typeof(T).GetProperties())
            {
                if (!TypeMapping.ContainsKey(property.PropertyType))
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

        protected async Task<List<T>> ListAsync<T>(string tableName, string where)
        {
            var propertyNames = new List<string>();
            var properties = typeof(T).GetProperties();
            foreach (var property in typeof(T).GetProperties())
            {
                if (!TypeMapping.ContainsKey(property.PropertyType))
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

        private List<T> List<T>(string tableName, string where)
        {
            var propertyNames = new List<string>();
            var properties = typeof(T).GetProperties();
            foreach (var property in typeof(T).GetProperties())
            {
                if (!TypeMapping.ContainsKey(property.PropertyType))
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
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
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
                var dbType = TypeMapping[property.PropertyType];

                var ordinal = record.GetOrdinal(property.Name);

                if (record[ordinal] is DBNull)
                    continue;
                
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
