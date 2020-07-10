using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using FAS.Core.Entities;
using FAS.Core.Exceptions;
using FAS.Core.Persistence;

namespace FAS.Persistence
{
    public sealed class SeminarsDao : Dao<Seminar, string>, ISeminarDao
    {
        private readonly string _connectionString;

        public SeminarsDao(string connectionString) : base((nameof(Seminar.Id), DbType.AnsiString), "Seminars", connectionString)
        {
            _connectionString = connectionString;
        }

        public override async Task AddAsync(Seminar seminar)
        {
            const string sql = @"INSERT INTO [Seminars] 
                                     ([Id],
                                      [Name],
                                      [LecturerId])
                               Values
                                     (@Id,
                                      @Name,
                                      @LecturerId)";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", seminar.Id);
                    cmd.Parameters.AddWithValue("@Name", seminar.Name);
                    cmd.Parameters.AddWithValue("@LecturerId", seminar.LecturerId);

                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task AddAttendeeAsync(SeminarAttendee attendee)
        {
            const string sql = @"INSERT INTO [SeminarAttendees] 
                                     ([Id],
                                      [SeminarId],
                                      [RegistrationTime])
                               Values
                                     (@Id,
                                      @SeminarId,
                                      @RegistrationTime)";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", attendee.Id);
                    cmd.Parameters.AddWithValue("@SeminarId", attendee.SeminarId);
                    cmd.Parameters.AddWithValue("@RegistrationTime", attendee.RegistrationTime);

                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task RemoveAttendeeAsync(SeminarAttendee attendee)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand("DELETE FROM [SeminarAttendees] WHERE [Id] = @Id AND [SeminarId] = @SeminarId", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", attendee.Id);
                    cmd.Parameters.AddWithValue("@SeminarId", attendee.SeminarId);
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<Seminar> GetAsync(string id)
        {
            const string sql = @"SELECT se.[Id]
                                      ,se.[Name]
                                      ,se.[LecturerId]
	                                  ,sa.Id AS AttendeeId
	                                  ,sa.RegistrationTime
                                  FROM [dbo].[Seminars] se
	                                LEFT JOIN [dbo].[SeminarAttendees] sa
	                                ON se.Id = sa.SeminarId
	                                WHERE se.Id = @Id";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    await conn.OpenAsync();

                    var reader = await cmd.ExecuteReaderAsync();
                    if (!reader.HasRows)
                        throw new ObjectNotFoundException(id, typeof(Seminar));

                    Seminar result = null;

                    while (await reader.ReadAsync())
                    {
                        if (result == null)
                        {
                            result = new Seminar
                            {
                                Id = id,
                                LecturerId = reader.GetString(reader.GetOrdinal("LecturerId")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                RegisteredAttendees = new List<SeminarAttendee>()
                            };
                        }

                        if (reader[reader.GetOrdinal("AttendeeId")] is DBNull)
                            break;

                        result.RegisteredAttendees.Add(new SeminarAttendee
                        {
                            Id = reader.GetString(reader.GetOrdinal("AttendeeId")),
                            SeminarId = id,
                            RegistrationTime = reader.GetDateTime(reader.GetOrdinal("RegistrationTime")),
                        });
                    }

                    return result;
                }
            }
        }
    }
}
