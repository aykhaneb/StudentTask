using Microsoft.AspNetCore.Mvc;
using StudentTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student{
                    Id=1,
                    Name="Aykhan"
                },
                new Student{
                    Id=2,
                    Name="Elvin"
                },
                new Student{
                    Id=3,
                    Name="Sahlar"
                }
            };

            return View(students);
        }
    }
}
