using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public string Index()
        {
            return "Course/Index Page";
        }

        public string List()
        {
            return "Course/List Page";
        }
        
    }
}