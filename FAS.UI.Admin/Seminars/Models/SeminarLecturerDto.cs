using FAS.Persistence;

namespace FAS.UI.Admin.Seminars.Models
{
    [TableName("Lecturers")]
    public sealed class SeminarLecturerDto : IQueryable
    {
        public string Id { get; set; }
        public string FullName { get; set; }

        public override string ToString() => FullName;
    }
}
