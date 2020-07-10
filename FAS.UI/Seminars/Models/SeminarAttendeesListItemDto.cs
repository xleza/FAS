using System;
using FAS.Persistence;

namespace FAS.UI.Seminars.Models
{
    [TableName("SeminarAttendeesView")]
    public sealed class SeminarAttendeesListItemDto : IQueryable
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime RegistrationTime { get; set; }
    }
}
