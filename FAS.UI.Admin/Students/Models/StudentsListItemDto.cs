﻿using System;
using FAS.Persistence;

namespace FAS.UI.Admin.Students
{
    [TableName("Students")]
    public sealed class StudentsListItemDto : IQueryable
    {
        [Pk]
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
