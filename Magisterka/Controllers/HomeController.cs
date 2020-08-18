using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        /*


       STRONA KOPCIA    


       */
        public IActionResult PoziomyKopec()
        {
            ViewData["Message"] = "Obliczenia długosci poziomego wymiennika ciepła wg. Kopcia";
            var model = new PKO();
            model.BOX1 = "style1";
            model.BOX2 = "style1";
            model.BOX3 = "style1";
            model.BOX4 = "style1";
            model.BOX5 = "style1";
            model.BOX6 = "style1";
            model.Selector3 = "?";
            return View(model);
        }

        [HttpPost]

        public ActionResult PoziomyKopec(PKO c, string Oblicz)

        {

            switch (Oblicz)
                {
                case "btn1" :
                    c.KQ0 = c.KQc * ((c.KCOP - 1) / c.KCOP);
                    c.KQ0 = Math.Round(c.KQ0, 4);
                    c.BOX1 = "style2";
                    c.BOX2 = "style1";
                    c.BOX3 = "style1";
                    c.BOX4 = "style1";
                    c.BOX5 = "style1";
                    c.BOX6 = "style1";
                    return View(c);
                case "btn2":
                    c.KB = c.KH / c.KZ;
                    c.KB = Math.Round(c.KB, 4);
                    c.BOX1 = "style1";
                    c.BOX2 = "style2";
                    c.BOX3 = "style1";
                    c.BOX4 = "style1";
                    c.BOX5 = "style1";
                    c.BOX6 = "style1";
                    return View(c);
                   
                case "btn3":
                    c.DT = c.Ktp - c.KTgm + c.KB * (c.KTgr - c.Ktp);
                    c.BOX1 = "style1";
                    c.BOX2 = "style1";
                    c.BOX3 = "style2";
                    c.BOX4 = "style1";
                    c.BOX5 = "style1";
                    c.BOX6 = "style1";
                    return View(c);
                case "btn4":
                    c.KC = ((2 * c.KAgr) / (c.Kalfag * c.Kdw)) / ((c.KAgr / c.KAr) * Math.Log(c.Kdz / c.Kdw)) + Math.Log(((2 * c.KAgr) / c.Kdz) * ((1 / c.Kalfap) + (c.KZ / c.KAgr)));
                    c.KC = Math.Round(c.KC, 8);
                    c.KK = (1 / Math.PI) * Math.Exp(c.KC + (Math.Pow(Math.PI, 2) / 4) * Math.Exp(-2 * c.KC)) * Math.Sin(Math.PI * c.KB);
                    c.KK = Math.Round(c.KK, 8);
                    c.BOX1 = "style1";
                    c.BOX2 = "style1";
                    c.BOX3 = "style1";
                    c.BOX4 = "style2";
                    c.BOX5 = "style1";
                    c.BOX6 = "style1";
                    return View(c);
                case "btn5":
                    Convert.ToDouble(c.Selector3);
                    double itemek;
                    itemek = Convert.ToDouble(c.Selector3);
                    c.KqL = (c.DT * c.Agr * ((2 * Math.PI) / (Math.Log(c.KK + Math.Sqrt(Math.Pow(c.KK, 2) - 1 )))))*itemek;
                    c.BOX1 = "style1";
                    c.BOX2 = "style1";
                    c.BOX3 = "style1";
                    c.BOX4 = "style1";
                    c.BOX5 = "style2";
                    c.BOX6 = "style1";
                    return View(c);
                case "btn6":
                    double A0;
                    c.Kqh = c.KqL / c.Kep;
                    A0 = c.KQ0 / c.Kqh;
                    c.KLp = A0 / c.Kep;
                    c.KLp = Math.Round(c.KLp, 2);
                    c.BOX1 = "style1";
                    c.BOX2 = "style1";
                    c.BOX3 = "style1";
                    c.BOX4 = "style1";
                    c.BOX5 = "style1";
                    c.BOX6 = "style2";
                    return View(c);
            }

            return View(c);
        }
        /*


       STRONA RUBIKA   


       */
        public IActionResult PoziomyRubik()
        {
            ViewData["Message"] = "Obliczenia długosci poziomego wymiennika ciepła wg. Rubika";
            var model = new Obl();
            model.BOX1 = "style1";
            model.BOX2 = "style1";
            model.Selector1 = "?";
            model.Selector2 = "?";
            return View(model);


        }
        [HttpPost]

        public ActionResult PoziomyRubik(Obl c, string Oblicz)

        {
            switch (Oblicz)
            {
                case "btn8":
                    c.RQ0 = c.RQg * ((c.RFi - 1) / c.RFi);
                    c.RQ0 = Math.Round(c.RQ0, 4);
                    c.BOX1 = "style2";
                    c.BOX2 = "style1";
                    return View(c);

                case "btn9":
                    Convert.ToDouble(c.Selector1);
                    double x, y;
                    x = Convert.ToDouble(c.Selector1);
                    y = Convert.ToDouble(c.Selector2);
                    c.RL = ((c.RQ0 * Math.Log(4 * x) / c.RDz) / (2 * Math.PI * y * (c.Rtinf - c.Rt)));
                    c.RL = Math.Round(c.RL, 2);
                    c.BOX1 = "style1";
                    c.BOX2 = "style2";
                    return View(c);
            }

            return View(c);
        }
        /*
         
             
        STRONA PIONOWEGO     
             
             
        */
        public IActionResult Pionowy()
        {
            ViewData["Message"] = "Obliczenia długosci pionowego wymiennika ciepła";
            var model = new PP();
            model.PVALUE = "?";
            model.STYL = "style1";
            return View(model);

        }

        [HttpPost]
        public ActionResult Pionowy(PP c, string Oblicz)
            
            {
                if (Oblicz == "btn4")
                {
                // c.PVALUE to warotsc dropdownu xD ;

                Convert.ToDouble(c.PVALUE);
                double x;
                x = Convert.ToDouble(c.PVALUE);
                c.PVALUE2 = x;
                c.STYL = "style2";
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
