using FAS.Persistence;

namespace FAS.UI.Reports.Models
{
    [TableName("Seminars")]
    public sealed class SeminarsListItemDto : IQueryable
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
