using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FAS.Persistence
{
    public abstract class Dao<TEntity, TId> : QueryDao
    {
        private readonly (string name, DbType type) _id;
        private readonly string _tableName;
        private readonly string _connectionString;


        protected Dao((string name, DbType type) id, string tableName, string connectionString) : base(connectionString)
        {
            _id = id;
            _tableName = tableName;
            _connectionString = connectionString;
        }

        protected Task<T> GetAsync<T>(TId id) => GetAsync<T>((_id.name, _id.type, id), id.ToString());

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

        protected async Task<bool> ExistByWheresAsync(string where)
        {
            if (where == null)
                throw new ArgumentNullException(nameof(where));

            var sql = $"SELECT Count(*) from {_tableName} WHERE {where}";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    await conn.OpenAsync();

                    return (int)await cmd.ExecuteScalarAsync() > 0;
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
                if (!TypeMapping.TryGetValue(property.PropertyType, out var type))
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
    }
}
