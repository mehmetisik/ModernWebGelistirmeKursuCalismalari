using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using ASPNetCoreIntro.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ASPNetCoreIntro.Controllers
{
    [Route(template:"deneme")]
    public class CustomerController : Controller
    {
        private ILogger _logger;

        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }

  
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        [Route(template:"save")]
        [Route(template:"~/anasayfa")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                Cities = new List<SelectListItem>
                {

                    new SelectListItem{ Text = "Ankara",Value = "06"},
                    new SelectListItem{ Text = "İzmir",Value = "35"},
                    new SelectListItem{ Text = "Malatya",Value = "44"},
                    new SelectListItem{ Text = "İstanbul",Value = "34"},

                }
            });
        }

        [HttpPost]
        [Route(template: "save")]
        public string SaveCustomer(Customer customer)
        {

            return "Kaydedildi";
        }


        [Route(template:"kisiListe")]
        public IActionResult Index2()
        {

            _logger.Log("");
            List<Customer> customers = new List<Customer>()
            {
                new Customer{Id = 1,FirstName ="Mehmet",LastName  = "IŞIK",City = "İstanbul"},
                new Customer{Id = 1,FirstName ="Ali",LastName  = "can",City = "İzmir"},
                new Customer{Id = 1,FirstName ="Ahmet",LastName  = "Kara",City = "Muş"},
                new Customer{Id = 1,FirstName ="İsmet",LastName  = "Kuyu",City = "Van"}

            };

            return View(customers);



        }
    }
}
