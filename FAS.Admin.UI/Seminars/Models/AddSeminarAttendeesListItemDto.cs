using System;
using FAS.Persistence;

namespace FAS.Admin.UI.Seminars.Models
{
    [TableName("Students")]
    public sealed class AddSeminarAttendeesListItemDto : IQueryable
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
