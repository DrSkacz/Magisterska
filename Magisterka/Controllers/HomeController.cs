using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Magisterka.Models;

namespace Magisterka.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Informacje o autorze programu.";

            return View();
        }

        public IActionResult PoziomyKopec()
        {
            ViewData["Message"] = "Obliczenia długosci poziomego wymiennika ciepła wg. Kopcia";

            return View();
        }

        public IActionResult PoziomyRubik()
        {
            ViewData["Message"] = "Obliczenia długosci poziomego wymiennika ciepła wg. Rubika";

            return View();
        }

        public IActionResult Pionowy()
        {
            ViewData["Message"] = "Obliczenia długosci pionowego wymiennika ciepła";

            return View();
        }

        public IActionResult Baza()
        {
            ViewData["Message"] = "Podgląd bazy danych";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
