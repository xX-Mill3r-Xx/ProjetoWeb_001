using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoWebMVC.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SimpleSearch()
        {
            return View();
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}