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
        /*


       ABOUT   


       */

        public IActionResult About()
        {
            ViewData["Message"] = "Informacje o autorze programu.";
           
            return View();
        }

        public IActionResult TEST()
        {
            ViewData["Message"] = "TEST";

            return View();
        }
        /*


       STRONA KOPCIA    


       */
        public IActionResult PoziomyKopec()
        {
            ViewData["Message"] = "Obliczenia długosci poziomego wymiennika ciepła wg. Kopcia";
            return View(new PKO());
        }

        [HttpPost]

        public ActionResult PoziomyKopec(PKO c, string Oblicz)

        {
            if (Oblicz == "btn1")
            {
                //Q0 = Qg * ((Fi - 1) / Fi);
            }
            else if (Oblicz == "btn2")
            {
                //B = H / Z;
            }
            else if (Oblicz == "btn3")
            {
                //x = X4 - X3 + B * (X2 - X4);
            }
            else if (Oblicz == "btn4")
            {
                // C = ((2 * X3) / (X1 * X5)) + ((X3 / X4) * Math.Log(X6 / X5)) + Math.Log(((2 * X3) / X6) * ((1 / X2) + (Z / X3)));
                // K = (1 / PI) * Math.Exp(C + (Math.Pow(PI, 2) / 4) * Math.Exp(-2 * C)) * Math.Sin(PI * B);
            }
            else if (Oblicz == "btn5")
            {
                // qL = X1 * x * ((2 * PI) / (Math.Log(K + Math.Sqrt(Math.Pow(K, 2) - 1))));
                // ql1 = itm.Value * qL;
            }
            else if (Oblicz == "btn6")
            {
                /*
                qH = qL / EP;
                A0 = Q0 / qH;
                Lp = A0 / EP; 
                */
            }

            return View(c);
        }
        /*


       STRONA RUBIKA   


       */
        public IActionResult PoziomyRubik()
        {
            ViewData["Message"] = "Obliczenia długosci poziomego wymiennika ciepła wg. Rubika";
            return View(new Obl());

            /* Trzeba to przemyśleć
             var model = new Listy();
            model.Lista1 = "0";
            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PoziomyRubik(Listy model)
        {
            if (ModelState.IsValid)
            {
                var msg = model.Lista1 + " selected";
                return RedirectToAction("IndexSuccess", new { message = msg });
            }

            // If we got this far, something failed; redisplay form.
            return View(model);
            */
        }

        [HttpPost]

        public ActionResult PoziomyRubik(Obl c, string Oblicz)

        {
            if (Oblicz == "btn8")
            {
                c.RQ0 = c.RQg * ((c.RFi - 1) / c.RFi);
                c.RQ0 = Math.Round(c.RQ0, 4);
            }
            else if (Oblicz == "btn9")
            {
                //https://www.c-sharpcorner.com/article/different-ways-bind-the-value-to-razor-dropdownlist-in-aspnet-mvc5/?fbclid=IwAR3PYSguG67mOEloWBB45wbQciE9ruRYUXFdOHrho4gd5dtwc5v8OAkpADs
                c.RL = c.Selector1;
                /*L = (Q0 * Math.Log((4 * x) / Dz) / (2 * PI * itm.Value * (tinf - t)));
                 X- to value z 1 selecta a itmvalue z 2*/


               // c.Glebokosc=Request.Form["GlebokoscUlozeniaRury"];
                c.Gleba = Request.Form["Grunt gliniasty"];
            }
          

            return View(c);
        }
        /*
         
             
        STRONA PIONOWEGO     
             
             
        */
        public IActionResult Pionowy()
        {
            ViewData["Message"] = "Obliczenia długosci pionowego wymiennika ciepła";
            return View(new PP());
        }
        [HttpPost]

        public ActionResult Pionowy(PP c, string Oblicz)

        {
            if (Oblicz == "")
            {
               //NIE WIEM JESZCZE
            }
            else if (Oblicz == "")
            {
                //NIE WIEM JESZCZE
            }


            return View(c);
        }

        /*


       WYŚWIETLANIE BAZY DANYCH TU BEDZIE
       COS O GRID NIE WIEM JESZCZE CZY BAZY NIE ROZBIC NA 3


       */

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
