using FAS.Persistence;

namespace FAS.UI.Sessions.Models
{
    [TableName("Seminars")]
    public sealed class SessionsDropDownListItemDto : IQueryable
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
