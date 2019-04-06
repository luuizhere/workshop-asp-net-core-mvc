using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departaments> list = new List<Departaments>();
            list.Add(new Departaments { Id = 1, Name = "Eletronics" });
            list.Add(new Departaments { Id = 2, Name = "Fasion" });
            return View(list);

        }
    }
}