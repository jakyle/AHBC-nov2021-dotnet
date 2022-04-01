using intro_web_api.Services.DALModels;
using System.Collections.Generic;

namespace intro_web_api.Services.Services
{
    public interface ISchoolContext : IAddStudent, IDeleteStudent, IUpdateStudent, IGetStudent, IGetStudents
    {
    }

    public interface IAddStudent
    {
        Student AddStudent(Student student);
    }

    public interface IDeleteStudent
    {
        Student DeleteStudent(int id);
    }

    public interface IUpdateStudent
    {
        Student UpdateStudent(int id, Student student);
    }

    public interface IGetStudent
    {
        Student GetStudent(int id);
    }

    public interface IGetStudents
    {
        IEnumerable<Student> GetStudents();
    }
}
