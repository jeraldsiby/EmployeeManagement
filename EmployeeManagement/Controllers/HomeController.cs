using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRpository; 

        public HomeController(IEmployeeRepository employeeRpository)
        {
            _employeeRpository = employeeRpository;
        }
        
        [Route("~/")]
        public ViewResult Index()
        {
            var model= _employeeRpository.GetAllEmployee();
            return View("~/Views/Home/Index.cshtml", model);
        }
        
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRpository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }
        public ViewResult Create()
        {
            
            return View();
        }
    }
}