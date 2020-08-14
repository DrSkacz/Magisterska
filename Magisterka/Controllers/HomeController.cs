﻿using System;
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
            model.Selector3 = "?";
            return View(new PKO());
        }

        [HttpPost]

        public ActionResult PoziomyKopec(PKO c, string Oblicz)

        {
            if (Oblicz == "btn1")
            {
                c.KQ0 = c.KQc * ((c.KCOP - 1) / c.KCOP);
                c.KQ0 = Math.Round(c.KQ0, 4);
                //Q0 = Qg * ((Fi - 1) / Fi);
            }
            else if (Oblicz == "btn2")
            {
                c.KB = c.KH / c.KZ;
                c.KQ0 = Math.Round(c.KQ0, 4);
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
            var model = new Obl();
            model.Selector1 = "?";
            model.Selector2 = "?";
            return View(new Obl());
         
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
                Convert.ToDouble(c.Selector1);
                double x,y;
                x = Convert.ToDouble(c.Selector1);
                y = Convert.ToDouble(c.Selector2);
                c.RL = ((c.RQ0 * Math.Log(4*x)/c.RDz)/(2*Math.PI*y*(c.Rtinf - c.Rt)));
                c.RL = Math.Round(c.RL, 2);
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
