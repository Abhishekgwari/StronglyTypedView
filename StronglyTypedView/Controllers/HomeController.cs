using Microsoft.AspNetCore.Mvc;
using StronglyTypedView.Models;
using System.Diagnostics;

namespace StronglyTypedView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            //Employee obj = new Employee()                 //   making object of Employee model class
            //{

            //    EmpId = 101,
            //    EmpName = "Abhishek",
            //    Designation = "Manager",
            //    Salary = 40000
            //};
            /*return View(obj);*/              // passing obj in view


            var myEmployees = new List<Employee>       // List      // variable my employees
            {
                new Employee { EmpId = 101, EmpName= "Abhishek", Designation= "Developer", Salary= 45000 },
                new Employee { EmpId = 101, EmpName= "Aman", Designation= "Manager", Salary= 55000 },
                new Employee { EmpId = 101, EmpName= "Lokesh", Designation= "Team Lead", Salary= 65000 },
                new Employee { EmpId = 101, EmpName= "Neha", Designation= "Accontant", Salary= 75000 },

            };

            return View(myEmployees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
