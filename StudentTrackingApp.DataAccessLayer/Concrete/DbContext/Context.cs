using Microsoft.EntityFrameworkCore;
using StudentTracking.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.DataAccessLayer.Concrete.DBContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=CaseSiparisDb;integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<ExamTYT> ExamTYTs { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}
