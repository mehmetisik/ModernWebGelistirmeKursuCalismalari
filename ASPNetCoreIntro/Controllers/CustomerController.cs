using ASPNetCoreIntro.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreIntro.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SaveCustomer()
        {
            return View();
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
