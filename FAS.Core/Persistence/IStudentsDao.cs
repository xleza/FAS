﻿using System.Threading.Tasks;
using FAS.Core.Entities;

namespace FAS.Core.Persistence
{
    public interface IStudentsDao
    {
        Task<Student> GetAsync(string id);
        Task<bool> ExistsAsync(string id);
        Task AddAsync(Student student);
    }
}
