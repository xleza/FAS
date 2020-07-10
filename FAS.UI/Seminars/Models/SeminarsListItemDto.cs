using FAS.Persistence;

namespace FAS.UI.Seminars.Models
{
    [TableName("SeminarsView")]
    public sealed class SeminarsListItemDto : IQueryable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LecturerId { get; set; }
        public string LecturerName { get; set; }
    }
}
