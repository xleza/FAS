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
    public sealed class SessionsDao : Dao<SeminarSession, string>, ISeminarSessionDao
    {
        private readonly string _connectionString;
        private const string SeminarSession = "SeminarSessions";

        public SessionsDao(string connectionString) : base(("Id", DbType.AnsiString), SeminarSession, connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<SeminarSession> GetAsync(string id)
        {
            const string sql = @"SELECT ss.[Id]
                                       ,ss.[SeminarId]
                                       ,ss.[Status]
                                       ,ss.[StartTime]
                                       ,ss.[EndTime]
	                                   ,sa.Id as AttendeeId
	                                   ,sa.AttendeeStartTime 
                                   FROM [dbo].[SeminarSessions] ss
                                   LEFT JOIN [dbo].[SeminarSessionAttendees] sa
                                   ON ss.Id = sa.SessionId
                                   WHERE ss.Id = @Id";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    await conn.OpenAsync();

                    var reader = await cmd.ExecuteReaderAsync();
                    if (!reader.HasRows)
                        throw new ObjectNotFoundException(id, typeof(SeminarSession));

                    SeminarSession result = null;

                    while (await reader.ReadAsync())
                    {
                        if (result == null)
                        {
                            result = new SeminarSession
                            {
                                Id = id,
                                SeminarId = reader.GetString(reader.GetOrdinal("SeminarId")),
                                StartTime = reader[reader.GetOrdinal("StartTime")] is DBNull ? default(DateTime?) : reader.GetDateTime(reader.GetOrdinal("StartTime")),
                                EndTime = reader[reader.GetOrdinal("EndTime")] is DBNull ? default(DateTime?) : reader.GetDateTime(reader.GetOrdinal("EndTime")),
                                Status = (SessionStatus)Enum.Parse(typeof(SessionStatus), reader.GetString(reader.GetOrdinal("Status"))),
                                Attendees = new List<SessionAttendee>()
                            };
                        }

                        if (reader[reader.GetOrdinal("AttendeeId")] is DBNull)
                            break;

                        result.Attendees.Add(new SessionAttendee
                        {
                            Id = reader.GetString(reader.GetOrdinal("AttendeeId")),
                            SessionId = id,
                            AttendeeStartTime = reader.GetDateTime(reader.GetOrdinal("AttendeeStartTime")),
                        });
                    }

                    return result;
                }
            }
        }

        public Task<bool> ExistsByIdAsync(string id) => ExistsAsync(id);

        public Task<bool> ExistsByWhereAsync(string where) => ExistByWheresAsync(where);

        public override async Task AddAsync(SeminarSession session)
        {
            const string sql = @"INSERT INTO [SeminarSessions] 
                                     ([Id],
                                      [SeminarId],
                                      [Status],
                                      [StartTime],
                                      [EndTime])
                               Values
                                     (@Id,
                                      @SeminarId,
                                      @Status,
                                      @StartTime,
                                      @EndTime)";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", session.Id);
                    cmd.Parameters.AddWithValue("@SeminarId", session.SeminarId);
                    cmd.Parameters.AddWithValue("@Status", session.Status.ToString());

                    cmd.Parameters.AddWithValue("@StartTime", (object)session.StartTime ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EndTime", (object)session.EndTime ?? DBNull.Value);

                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateAsync(SeminarSession session)
        {
            const string sql = @"UPDATE [SeminarSessions]
                                   SET [SeminarId] = @SeminarId
                                      ,[Status] = @Status
                                      ,[StartTime] = @StartTime
                                      ,[EndTime] = @EndTime
                                 WHERE Id = @Id";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", session.Id);
                    cmd.Parameters.AddWithValue("@SeminarId", session.SeminarId);
                    cmd.Parameters.AddWithValue("@Status", session.Status.ToString());
                    cmd.Parameters.AddWithValue("@StartTime", (object)session.StartTime ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EndTime", (object)session.EndTime ?? DBNull.Value);

                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task AddAttendeeAsync(SessionAttendee attendee)
        {
            const string sql = @"INSERT INTO [SeminarSessionAttendees] 
                                     ([Id],
                                      [SessionId],
                                      [AttendeeStartTime])
                               Values
                                     (@Id,
                                      @SessionId,
                                      @AttendeeStartTime)";

            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", attendee.Id);
                    cmd.Parameters.AddWithValue("@SessionId", attendee.SessionId);
                    cmd.Parameters.AddWithValue("@AttendeeStartTime", attendee.AttendeeStartTime);

                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public Task<List<SeminarSession>> ListAsync(string @where)
        {
            throw new NotImplementedException();
        }
    }
}
