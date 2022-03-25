using Entity_Web_App.Services.DALModels;
using System.Collections.Generic;

namespace Entity_Web_App.Services
{
    public interface ISchoolContext : IAddStudent, IDeleteStudent, IUpdateStudent, IGetStudent, IGetStudents
    { 
    }

    public interface IAddStudent
    {
        void AddStudent(Student student);
    }

    public interface IDeleteStudent
    {
        void DeleteStudent(int id);
    }

    public interface IUpdateStudent
    {
        void UpdateStudent(int id, Student student);
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
