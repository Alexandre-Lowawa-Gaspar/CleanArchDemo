using CleanArchDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CleanArchDemo.Infra.Repository.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Student { get; set; }
    }
}