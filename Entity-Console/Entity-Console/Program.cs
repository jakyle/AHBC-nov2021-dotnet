using Entity_Console.Models;
using Entity_Console.Services;
using System;
using System.Linq;

namespace Entity_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new SchoolContext())
            {
                var student = new Student()
                {
                    Name = "Billy",
                    Grade = 85
                };
                context.Students.Add(student);

                //context.SaveChanges();

                var studentsNamedSally = context.Students
                    .Where(s => s.Name == "Sally")
                    .ToList();

                var billy = context.Students.Find(2);
                context.Students.Remove(billy);

                var sally = context.Students.Find(1);
                sally.Grade = 100;
                context.Students.Update(sally);

                context.SaveChanges();


                Console.WriteLine(studentsNamedSally.Count);
            }

        }
    }
}
