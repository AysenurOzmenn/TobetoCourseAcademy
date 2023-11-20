using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class CourseAcademyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CourseAcademyDb;Trusted_Connection=true;encrypt=false");
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
    }
}

