using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please enter your name!")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please enter your email!")]
        [EmailAddress(ErrorMessage = "Please enter a valid email!")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Please enter your phone number!")]
        public string Phone { get; set; }
        
        public bool? Confirm { get; set; }
    }
}