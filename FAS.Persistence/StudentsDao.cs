using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using FAS.Core.Entities;
using FAS.Core.Persistence;

namespace FAS.Persistence
{
    public sealed class StudentsDao : Dao<Student, string>, IStudentsDao
    {

        public StudentsDao(string connectionString) : base((nameof(Student.Id), DbType.AnsiString), "Students", connectionString)
        {
        }

        public Task<Student> GetAsync(string id) => null;


        public Task UpdateAsync(Student student)
        {
            throw new System.NotImplementedException();
        }

      
        //public async Task<List<T>> QueryAsync<T>(string table, string where = null)
        //{
        //    var properties = typeof(T).GetProperties();
        //    var sql = $"SELECT {properties} from {table}";
        //    if (where != null)
        //        sql += $"WHERE {where}";

        //    var result = new List<T>();

        //    using (var conn = new SqlConnection(_connectionString))
        //    {
        //        using (var cmd = new SqlCommand(sql, conn))
        //        {
        //            await conn.OpenAsync();
        //            var reader = await cmd.ExecuteReaderAsync();
        //            while (await reader.ReadAsync())
        //            {
        //                result.Add(CreateInstance<T>(reader, properties));
        //            }
        //        }
        //    }

        //    return result;
        //}

        //private async Task ExistsAsync(string where)
        //{
        //    var properties = typeof(T).GetProperties();
        //    var sql = $"SELECT TOP (1) {properties} from {table}";
        //    if (where != null)
        //        sql += $"WHERE {where}";

        //    using (var conn = new SqlConnection(_connectionString))
        //    {
        //        using (var cmd = new SqlCommand(sql, conn))
        //        {
        //            await conn.OpenAsync();
        //            var reader = await cmd.ExecuteReaderAsync();

        //            return !await reader.ReadAsync() ? default : CreateInstance<T>(reader, properties);
        //        }
        //    }
        //}


        //private async Task<T> QueryOneAsync<T>(string table, string where = null)
        //{
        //    var properties = typeof(T).GetProperties();
        //    var sql = $"SELECT TOP (1) {properties} from {table}";
        //    if (where != null)
        //        sql += $"WHERE {where}";

        //    using (var conn = new SqlConnection(_connectionString))
        //    {
        //        using (var cmd = new SqlCommand(sql, conn))
        //        {
        //            await conn.OpenAsync();
        //            var reader = await cmd.ExecuteReaderAsync();

        //            return !await reader.ReadAsync() ? default : CreateInstance<T>(reader, properties);
        //        }
        //    }
        //}
    }
}
