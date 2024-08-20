using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class AttendanceContext : DbContext
    {
        private readonly string _connectionString;
        public AttendanceContext()
        {
            _connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=CSharpB16;User ID=csharpb17;Password=123456;TrustServerCertificate=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Attendance>().ToTable("Attendances");
            modelBuilder.Entity<Admin>().ToTable("Admins");

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity(j => j.ToTable("StudentCourses"));

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Courses)
                .WithMany(c => c.Teachers)
                .UsingEntity(j => j.ToTable("TeacherCourses"));

            modelBuilder.Entity<Course>()
                .Property(c => c.Fees)
                .HasColumnType("decimal(18,2)"); 



            modelBuilder.Entity<Admin>().HasData(
                new Admin { Id = 1, Username = "admin", Password = "admin" }
            );

            modelBuilder.Entity<Teacher>().HasData(
             new Teacher { Id = 1, Name = "Nasim", Username = "teacher", Password = "teacher" }
         );

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Reza", Username = "student", Password = "student" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, CourseName = "C#", Fees = 100m }
            );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
    
}

