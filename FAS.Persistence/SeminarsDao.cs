using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using FAS.Core.Entities;
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
                using (var cmd = new SqlCommand("Remove FROM [SeminarAttendees] WHERE [Id] = @Id AND [SeminarId] = @SeminarId", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", attendee.Id);
                    cmd.Parameters.AddWithValue("@SeminarId", attendee.SeminarId);
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public Task<Seminar> GetAsync(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
