using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magisterka.Models;
using Microsoft.AspNetCore.Mvc;

namespace Magisterka.Controllers
{
    public class CalcController : Controller
    {


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public IActionResult PoziomyRubik()
        {
            return View(new Obl());
        }

        [HttpPost]

        public ActionResult PoziomyRubik(Obl c,string Oblicz)

        {
            if(Oblicz == "btn8")
            {
                c.RQ0 = c.RQg * ((c.RFi-1) / c.RFi);
            }
            else if (Oblicz == "btn9")
            {
                c.RL = (c.RQ0*c.RDz)+(c.Rtinf - c.Rt);
              
                     /*L = (Q0 * Math.Log((4 * x) / Dz) / (2 * PI * itm.Value * (tinf - t)));*/
            }

            return View(c);
        }
    }
}