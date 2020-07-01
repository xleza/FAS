using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using FAS.Core.Entities;
using FAS.Core.Persistence;

namespace FAS.Persistence
{
    public sealed class StudentsDao : IStudentsDao
    {
        private readonly string _connectionString;

        public StudentsDao(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Task<Student> GetAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAsync(Student student)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Student student)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<T>> QueryAsync<T>(string where = null)
        {
            var properties = typeof(T).GetProperties();
            var sql = $"SELECT {properties} from Students";
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
                        var instance = Activator.CreateInstance<T>();
                        foreach (var property in properties)
                        {
                            var dbNull = reader[property.Name] is DBNull;

                            if (dbNull && property.PropertyType.IsClass)
                                continue;

                            if (dbNull && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                throw new Exception("Can't assign null to not nullable property");

                            var ordinal = reader.GetOrdinal(property.Name);
                            if (property.PropertyType == typeof(int))
                                property.SetValue(instance, reader.GetInt32(ordinal));
                            else if (property.PropertyType == typeof(long))
                                property.SetValue(instance, reader.GetInt64(ordinal));
                            else if (property.PropertyType == typeof(string))
                                property.SetValue(instance, reader.GetString(ordinal));
                            else if (property.PropertyType == typeof(byte[]))
                                property.SetValue(instance, (byte[])reader[ordinal]);
                            else
                                throw new Exception($"Processing type {property.PropertyType} is unsupported");
                        }
                        result.Add(instance);
                    }
                }
            }

            return null;
        }
    }
}
