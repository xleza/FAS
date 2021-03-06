﻿using System;
using FAS.Persistence;

namespace FAS.UI.Sessions.Models
{
    [TableName("SeminarSessionsView")]
    public sealed class SessionDetailedDto : IQueryable
    {
        [Pk]
        public string Id { get; set; }
        public string Name { get; set; }
        public string SeminarId { get; set; }
        public string LecturerFullName { get; set; }
        public string Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
