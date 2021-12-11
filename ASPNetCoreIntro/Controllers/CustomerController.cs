using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ASPNetCoreIntro.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
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
        public string SaveCustomer(Customer customer)
        {

            return "Kaydedildi";
        }



        public IActionResult Index2()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer
                {

                    Id = 1,
                    FirstName ="Mehmet",
                    LastName  = "IŞIK",
                    City = "İstanbul"

                },
                new Customer
                {

                    Id = 1,
                    FirstName ="Ali",
                    LastName  = "can",
                    City = "İzmir"

                },
                new Customer
                {

                    Id = 1,
                    FirstName ="Ahmet",
                    LastName  = "Kara",
                    City = "Muş"

                },
                new Customer
                {

                    Id = 1,
                    FirstName ="İsmet",
                    LastName  = "Kuyu",
                    City = "Van"

                }

            };

            return View(customers);



        }
    }
}
