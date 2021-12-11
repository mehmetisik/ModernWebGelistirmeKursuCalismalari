using ASPNetCoreIntro.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASPNetCoreIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Index1(int id)
        {
            return id.ToString();
        }

       
    }
}
