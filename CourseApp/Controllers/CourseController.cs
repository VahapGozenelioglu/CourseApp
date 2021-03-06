using System;
using System.Collections.Generic;
using System.Linq;
using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            Course course = new Course() { Description = "Web Development Course" , Name = "ASP.NET Core", IsPublished = true};
            List<Student> Students = new List<Student>()
            {
                new Student() {Name = "Ahmet"},
                new Student() {Name = "Mehmet"}
            };

            CourseStudentsViewModel viewModel = new CourseStudentsViewModel()
            {
                Course = course,
                Students = Students
            };
            
            return View(viewModel);
        }
        
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if(ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);    
            }
            return View(student);
        }
        
        [HttpGet]
        public IActionResult List()
        {
            var students = Repository.GetAllStudents().Where(i=>i.Confirm == true);
            return View(students);
        }
        public IActionResult Details()
        {
            Course course = new Course();
            course.Name = "Dotnet Core Mvc Course";
            course.Description = "It is a nice Course";
            course.IsPublished = true;

            return View(course);
        }

        public IActionResult CourseDetails(int? id, string sortby)
        {
            id = id.HasValue ? id : 1;
            sortby = String.IsNullOrEmpty(sortby) ? "name" : sortby;
            return Content("id = " + id + " sortby = " + sortby);
        }

        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content("year = " + year + " month = " + month);
        }
        
        
    }
}