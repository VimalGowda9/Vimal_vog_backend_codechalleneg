using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Database.Entities;

namespace VogCodeChallenge.Database
{
    public class VogContext : DbContext
    {
        public VogContext(DbContextOptions<VogContext> options)
            :base(options)
        {
        }

        public DbSet<DepartmentEntity> Department { get; set; }

        public DbSet<EmployeeEntity> Employee { get; set; }
    }
}