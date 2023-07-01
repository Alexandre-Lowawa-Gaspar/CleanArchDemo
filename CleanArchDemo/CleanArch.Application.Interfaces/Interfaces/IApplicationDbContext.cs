using CleanArchDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CleanArch.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Student { get; set; }
    }
}