

using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Extedions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreIntro.Controllers
{
    public class SessionDemoController : Controller
    {

        public string Index1()
        {
            Customer customer = new Customer { Id = 1, FirstName = "ipek" };

            HttpContext.Session.SetString("isim", "Mehmet");

            HttpContext.Session.SetObject("musteri", customer);
            return "Sesion oluştu.";
        }

        public string Index2()
        {
            var customer = HttpContext.Session.GetObject<Customer>("musteri");
            return customer.Id.ToString() + " " + customer.FirstName.ToString();
        }

    }
}
