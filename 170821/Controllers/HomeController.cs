using _170821.Models;
using _170821.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _170821.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<int> numbers = new List<int> { 1, 2, 3};
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="Ulvi",Surname="Garazade"},
                new Student{Id=2,Name="ABC",Surname="DEF"},
                new Student{Id=3,Name="GHI",Surname="JKL"}
            };

            HomeViewModel model = new HomeViewModel
            {
                Students = students,
                Numbers = numbers
            };

            return View(model);
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
