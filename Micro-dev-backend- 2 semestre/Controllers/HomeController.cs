using Micro_dev_backend__2_semestre.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Micro_dev_backend__2_semestre.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           return RedirectToAction("Index", "Veiculos");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
