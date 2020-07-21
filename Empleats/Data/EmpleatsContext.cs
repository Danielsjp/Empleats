using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Empleats.Models;

namespace Empleats.Data
{
    public class EmpleatsContext : DbContext
    {
        public EmpleatsContext (DbContextOptions<EmpleatsContext> options)
            : base(options)
        {
        }
        public DbSet<Empleats.Models.Employee> Employee { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");

        }
    }
}
