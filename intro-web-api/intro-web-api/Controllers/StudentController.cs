using intro_web_api.Models.School;
using intro_web_api.Services.DALModels;
using intro_web_api.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace intro_web_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ISchoolContext _schoolContext;

        public StudentController(ISchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }


        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_schoolContext.GetStudents());
        }

        [HttpGet]
        [Route("{studentId}")] //localhost:5001/student/1
        public IActionResult GetStudent([FromRoute] int studentId)
        {
            var student = _schoolContext.GetStudent(studentId);

            if (student != null)
            {
                return Ok(student);
            }

            return NotFound($"No student matching the provided student id: {studentId}");
        }


        [HttpDelete]
        [Route("{studentId}")]
        public IActionResult DeleteStudent([FromRoute] int studentId)
        {
            var dbStudent = _schoolContext.DeleteStudent(studentId);

            if (dbStudent == null)
            {
                return NotFound($"{nameof(studentId)}: {studentId} does not exist");
            }

            return Accepted($"Student with ID: {studentId} has been removed");
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] PostStudentRequest postStudentRequest)
        {
            var student = new Student();
            student.Name = postStudentRequest.Name;
            student.Grade = postStudentRequest.Grade;

            var dbStudent = _schoolContext.AddStudent(student);

            return Created($"https://localhost:5001/{dbStudent.StudentId}", dbStudent);
        }

        [HttpPut]
        [Route("{studentId}")]
        public IActionResult PutStudent([FromBody] PostStudentRequest postStudentRequest, [FromRoute] int studentId)
        {
            var student = new Student();
            student.Name = postStudentRequest.Name;
            student.Grade = postStudentRequest.Grade;

            var dbStudent = _schoolContext.UpdateStudent(studentId, student);

            if (dbStudent == null)
            {
                return NotFound($"{nameof(studentId)}: {studentId} does not exist");
            }

            return Created($"https://localhost:5001/{dbStudent.StudentId}", dbStudent);
        }

    }
}
