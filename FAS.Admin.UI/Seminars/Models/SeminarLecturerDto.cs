using FAS.Persistence;

namespace FAS.Admin.UI.Seminars.Models
{
    [TableName("Lecturers")]
    public sealed class SeminarLecturerDto : IQueryable
    {
        public string Id { get; set; }
        public string FullName { get; set; }

        public override string ToString() => FullName;
    }
}
