using System.Collections.Generic;
using CourseApp.Models;

namespace CourseApp.ViewModels
{
    public class ProductCategoriesViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}