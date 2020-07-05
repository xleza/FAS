using System;

namespace FAS.UI.Lecturer.Models
{
    public sealed class LecturersListItemDto
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
