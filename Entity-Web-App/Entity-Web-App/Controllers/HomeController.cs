using Entity_Web_App.Models;
using Entity_Web_App.Models.Home;
using Entity_Web_App.Services;
using Entity_Web_App.Services.DALModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Web_App.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISchoolContext _schoolContext;

        // we are getting access to our School context through this constructor via Dependancy
        // Injection.  BECASE we added of type SchoolContext into our services collection 
        // in our Startup.cs, we have acces to this type for ANY other servicest that is 
        // ALSO in our services collection.
        public HomeController(ISchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new IndexViewModel();
            model.Students = _schoolContext.GetStudents();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            // var model = new IndexViewModel();
            model.Students = _schoolContext.GetStudents();
            return View(model);
        }


        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }


        public IActionResult SomeText()
        {
            var numbers = new int[1]{ 0};

            var x = numbers[10];

            return Ok("sup dude lol, I'm just some text!");
        }

        [HttpPost]
        public IActionResult AddStudent(AddStudentViewModel viewModel)
        {
            _schoolContext.AddStudent(viewModel.Student);

            var studentThing = nameof(viewModel); // "dbStudent", nameof converts the VARIABLE name into a string

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteStudent(int id)
        {
            _schoolContext.DeleteStudent(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateStudent(int id)
        {
            var dbStudent = _schoolContext.GetStudent(id);

            if (dbStudent != null)
            {
                var model = new UpdateStudentViewModel();
                model.Student = dbStudent;

                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult UpdateStudent(int id, UpdateStudentViewModel model)
        {
            _schoolContext.UpdateStudent(id, model.Student);
            return RedirectToAction(nameof(Index));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
