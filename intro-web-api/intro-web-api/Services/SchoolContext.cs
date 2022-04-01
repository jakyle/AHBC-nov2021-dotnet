using intro_web_api.Services.DALModels;
using intro_web_api.Services.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace intro_web_api.Services
{
    public class SchoolContext : DbContext, ISchoolContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public Student AddStudent(Student student)
        {
            var studentEntity = Students.Add(student).Entity;
            SaveChanges();
            return studentEntity;
        }

        public Student DeleteStudent(int id)
        {
            var dbStudent = Students.Find(id);

            if (dbStudent != null)
            {
                var entity = Students.Remove(dbStudent).Entity;
                SaveChanges();
                return entity;
            }

            return null;
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

        public Student UpdateStudent(int id, Student student)
        {
            var dbStudent = Students.Find(id);

            // if the student is NOT null, this means the student exist in the database by id
            if (dbStudent != null)
            {
                dbStudent.Grade = student.Grade;
                dbStudent.Name = student.Name;

                var entityStudent = Students.Update(dbStudent).Entity;
                SaveChanges();
                return entityStudent;
            }

            return null;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( // your connection string goes INSIDE THIS METHOD, ALSO CHANGE THE INITIAL CATALOG TO YOUR DATABASE
             @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=School;Integrated Security=True");
        }

    }
}
