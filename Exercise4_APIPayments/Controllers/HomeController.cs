using Exercise4_APIPayments.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exercise4_APIPayments.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            var product = new Product()
            {
                Price = 77.74
            };
            return View(product);
        }

        public IActionResult TransactionComplete()
        {
            return View();
        }
    }
}