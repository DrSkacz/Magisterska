using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Magisterka.Models;

namespace Magisterka.Controllers
{
    public class BazaController : Controller
    {
        private readonly MagisterkaContext _context;

        public BazaController(MagisterkaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Baza.ToListAsync());
        }

        // GET: Baza/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baza = await _context.Baza
                .FirstOrDefaultAsync(m => m.Id == id);
            if (baza == null)
            {
                return NotFound();
            }

            return View(baza);
        }

        // GET: Baza/Create
        public IActionResult Create()
        {
            var model = new Baza();

            List<string> zmienne = new List<string>();
            zmienne.Add("Zmienna zerowa");
            zmienne.Add("RQg");
            zmienne.Add("RQ0");
            zmienne.Add("RQg");
            zmienne.Add("RDz");
            zmienne.Add("Rtinf");
            zmienne.Add("Rt");
            zmienne.Add("RL");
//////////////////////////////////////////////////
            zmienne.Add("KQc");
            zmienne.Add("KCOP");
            zmienne.Add("KQ0");
            zmienne.Add("KH");
            zmienne.Add("KZ");
            zmienne.Add("KB");
            zmienne.Add("KTgr");
            zmienne.Add("DT");
            zmienne.Add("KTgm");
            zmienne.Add("KTp");
            zmienne.Add("Kalfag");
            zmienne.Add("Kalfap");
            zmienne.Add("KAgr");
            zmienne.Add("Agr");
            zmienne.Add("KAr");
            zmienne.Add("Kdw");
            zmienne.Add("Kdz");
            zmienne.Add("KK");
            zmienne.Add("KC");
            zmienne.Add("KqL");
            zmienne.Add("Kqh");
            zmienne.Add("Kep");
            zmienne.Add("KLp");
            //////////////////////////////////////////////////
            zmienne.Add("SQv");
            zmienne.Add("SLo");
            zmienne.Add("SQc");
            zmienne.Add("SCOP");
            zmienne.Add("STsp"); 
            zmienne.Add("SQ0");
            zmienne.Add("SLw");
            zmienne.Add("SdLw");
            //////////////////////////////////////////////////
            //,SQv,SLo,SLw,SdLw,SQc,SCOP,STsp,SQ0
            int x;
            string cos;
            x = zmienne.Count();    
            for (int n = 1; n < x; ++n)
            {
                cos = zmienne[n];
                if (TempData[zmienne[n]] != null)
                {
                    string a = TempData[cos].ToString();
                    model.GetType().GetProperty(cos).SetValue(model, a, null);
                    TempData.Remove(cos);
                }

            }



         /*   if (TempData["RQg"] != null)
            {
                model.RQg = TempData["RQg"].ToString();
                TempData.Remove("RQg");
            } */
     
            return View(model);
        }
        // POST: Baza/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // ("Id,RQg,RFi,Rro,RQ0,RXo,RDz,Rtinf,Rt,RL,KQc,KCOP,KQ0,KH,KZ,KB,KTgr,DT,KTgm,Ktp,Kalfag,Kalfap,KAgr,Agr,KAr,Kdw,Kdz,KK,KC,KqL,Kqh,Kep,KLp")
        //TYLKO DATA,Nazwa,Opis wymagane powinny byc
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DATA,Nazwa,Opis,RQg,RFi,RQ0,RDz,Rtinf,Rt,RL,KQc,KCOP,KQ0,KH,KZ,KB,KTgr,DT,KTgm,Ktp,Kalfag,Kalfap,KAgr,Agr,KAr,Kdw,Kdz,KK,KC,KqL,Kqh,Kep,KLp,SQv,SLo,SLw,SdLw,SQc,SCOP,STsp,SQ0")] Baza baza)
        {
 
            if (ModelState.IsValid)
                {
                    _context.Add(baza);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            
            return View(baza);
        }




        // GET: Baza/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baza = await _context.Baza.FindAsync(id);
            if (baza == null)
            {
                return NotFound();
            }
            return View(baza);
        }

        // POST: Baza/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DATA,Nazwa,Opis,RQg,RFi,RQ0,RDz,Rtinf,Rt,RL,KQc,KCOP,KQ0,KH,KZ,KB,KTgr,DT,KTgm,Ktp,Kalfag,Kalfap,KAgr,Agr,KAr,Kdw,Kdz,KK,KC,KqL,Kqh,Kep,KLp,SQv,SLo,SLw,SdLw,SQc,SCOP,STsp,SQ0")] Baza baza)
        {
            if (id != baza.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(baza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BazaExists(baza.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(baza);
        }

        // GET: Baza/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baza = await _context.Baza
                .FirstOrDefaultAsync(m => m.Id == id);
            if (baza == null)
            {
                return NotFound();
            }

            return View(baza);
        }

        // POST: Baza/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var baza = await _context.Baza.FindAsync(id);
            _context.Baza.Remove(baza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BazaExists(int id)
        {
            return _context.Baza.Any(e => e.Id == id);
        }
    }
}
