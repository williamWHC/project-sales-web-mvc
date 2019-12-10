using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectWebApiSales.Models;

namespace ProjectWebApiSales.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronicos"});
            list.Add(new Department { Id = 2, Name = "Fashion"});





            return View(list);
        }
    }
}