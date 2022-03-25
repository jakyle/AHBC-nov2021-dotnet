using Entity_Web_App.Services.DALModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Entity_Web_App.Services
{


    public class SchoolContext : DbContext, ISchoolContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void DeleteStudent(int id)
        {
            var dbStudent = Students.Find(id);

            if (dbStudent != null)
            {
                Students.Remove(dbStudent);
                SaveChanges();
            }
        }

        public Student GetStudent(int id)
        {
            var dbStudent = Students.Find(id);

            return dbStudent;
        }

        public IEnumerable<Student> GetStudents()
        {
            return Students;
        }

        public void UpdateStudent(int id, Student student)
        {
            var dbStudent = Students.Find(id);
            if ( dbStudent != null )
            {
                dbStudent.Grade = student.Grade;
                dbStudent.Name = student.Name;

                Students.Update(dbStudent);
                SaveChanges();
            }
        }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=School;Integrated Security=True");
        }
    }
}
