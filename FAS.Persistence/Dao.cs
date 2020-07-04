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
    public abstract class Dao<TEntity, TId>
    {
        private readonly (string name, DbType type) _id;
        private readonly string _tableName;
        private readonly string _connectionString;

        private readonly Dictionary<string, DbType> _typeMapping = new Dictionary<string, DbType>
        {
            { nameof(Int16), DbType.Int16 },
            { nameof(Int32), DbType.Int32 },
            { nameof(Int64), DbType.Int64 },
            { nameof(Decimal), DbType.Decimal },
            { nameof(String), DbType.String},
            { nameof(DateTime), DbType.DateTime},
            { typeof(byte[]).Name , DbType.Binary }
        };


        protected Dao((string name, DbType type) id, string tableName, string connectionString)
        {
            _id = id;
            _tableName = tableName;
            _connectionString = connectionString;
        }

        public virtual async Task<bool> ExistsAsync(TId id)
        {
            var sql = $"SELECT Count(*) from {_tableName} WHERE {_id.name} = @Id";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Id",
                        DbType = _id.type,
                        Value = id
                    });
                    await conn.OpenAsync();

                    return (int)await cmd.ExecuteScalarAsync() > 0;
                }
            }
        }

        public async Task<List<T>> ListAsync<T>(string where = null)
        {
            var propertyNames = new List<string>();
            var properties = typeof(T).GetProperties();
            foreach (var property in typeof(T).GetProperties())
            {
                if (!_typeMapping.ContainsKey(property.PropertyType.Name))
                    throw new NotSupportedException($"Can't store type {property.PropertyType.Name}");

                propertyNames.Add($"[{property.Name}]");
            }

            var sql = $@"SELECT {string.Join(",", propertyNames)} FROM {_tableName}";
            if (where != null)
                sql += $"WHERE {where}";

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


        public async Task<T> GetAsync<T>(TId id)
        {
            var propertyNames = new List<string>();
            var properties = typeof(T).GetProperties();
            foreach (var property in typeof(T).GetProperties())
            {
                if (!_typeMapping.ContainsKey(property.PropertyType.Name))
                    throw new NotSupportedException($"Can't store type {property.PropertyType.Name}");

                propertyNames.Add($"[{property.Name}]");
            }

            var sql = $@"SELECT {string.Join(",", propertyNames)} FROM {_tableName} WHERE {_id.name} = @Id";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Id",
                        DbType = _id.type,
                        Value = id
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

        public virtual async Task AddAsync(TEntity entity)
        {
            var properties = typeof(TEntity).GetProperties();
            var propertyNames = new List<string>();
            var commandParams = new List<SqlParameter>();

            foreach (var property in properties)
            {
                if (!_typeMapping.TryGetValue(property.PropertyType.Name, out var type))
                    throw new NotSupportedException($"Can't store type {property.PropertyType.Name}");

                propertyNames.Add($"[{property.Name}]");
                commandParams.Add(new SqlParameter
                {
                    ParameterName = $"@{property.Name}",
                    DbType = type,
                    Value = property.GetValue(entity)
                });
            }

            var sql = $@"INSERT INTO [{_tableName}] 
                                     ({string.Join(",", propertyNames)})
                               Values
                                     ({string.Join(",", commandParams.Select(param => param.ParameterName))})";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(commandParams.ToArray());

                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        private T CreateInstance<T>(IDataRecord record, IEnumerable<PropertyInfo> properties)
        {
            var instance = Activator.CreateInstance<T>();
            foreach (var property in properties)
            {
                var dbType = _typeMapping[property.PropertyType.Name];

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
