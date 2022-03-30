using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
namespace LINQ.Data
{
    public class MySchoolDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<SchoolSubject> SchoolSubjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-NUQ8SBJ;Initial Catalog=MyFirstSchool;Integrated Security = True;");
        }
    }
}
