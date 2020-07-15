using FAS.Persistence;

namespace FAS.UI.Reports.Models
{
    [TableName("StudentsAttendeesReportView")]
    public sealed class StudentsAttendanceReportDto : IQueryable
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public int AttendeesCount { get; set; }
        public string SeminarName { get; set; }
    }
}
