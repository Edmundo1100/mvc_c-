using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listaDepartamentos = new List<Department>();
            listaDepartamentos.Add(new Department { id = 1, Name = "Eletronicos" });
            listaDepartamentos.Add(new Department { id = 2, Name = "Fashion" });

            return View(listaDepartamentos);
        }
    }
}