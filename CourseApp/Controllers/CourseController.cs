using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        
        public IActionResult Details()
        {
            Course course = new Course();
            course.Name = "Dotnet Core Mvc Course";
            course.Description = "It is a nice Course";
            course.IsPublished = true;

            return View(course);
        }
        public string List()
        {
            return "Course/List Page";
        }
        
    }
}