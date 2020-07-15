using System;
using FAS.Persistence;

namespace FAS.UI.Sessions.Models
{
    [TableName("SeminarSessionAttendeesView")]
    public sealed class SessionAttendeesListItemDto : IQueryable
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime AttendeeStartTime { get; set; }
    }
}
