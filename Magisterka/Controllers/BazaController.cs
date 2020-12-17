using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Magisterka.Models;
using System.Reflection;

namespace Magisterka.Controllers
{
    public class BazaController : Controller
    {
        private readonly MagisterkaContext _context;

        public class ButtonModel
        {
            public string content { get; set; }
            public bool isPrimary { get; set; }

        }
        public BazaController(MagisterkaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Baza model = new Baza();
            List<ZmiennaItem> zmienne = model.Zmienne;
            return View(await _context.Baza.ToListAsync());
        }

        // GET: Baza/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Baza model = new Baza();
            List<ZmiennaItem> zmienne = model.Zmienne;
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
            Baza model = new Baza();
            List<ZmiennaItem> zmienne = model.Zmienne;

            int x;
            string cos;
            x = zmienne.Count();
            for (int n = 0; n < x; ++n)
            {
                cos = zmienne[n].Zmienna;
                if (TempData[zmienne[n].Zmienna] != null)
                {
                    string a = TempData[cos].ToString();
                    model.GetType().GetProperty(cos).SetValue(model, a, null);
                    TempData.Remove(cos);
                }

            }

            return View(model);
        }
        // POST: Baza/Create
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DATA,Nazwa,Opis,RQg,RFi,RQ0,RDz,Rtinf,Rt,RL,KQc,KCOP,KQ0,KH,KZ,KB,KTgr,DT,KTgm,Ktp,Kalfag,Kalfap,KAgr,Agr,KAr,Kdw,Kdz,KK,KC,KqL,Kqh,Kep,KLp,SQv,SLo,SLw,SdLw,SQc,SCOP,STsp,SQ0,BDz,BDw,Blambdar,Bn,Bgamma,BQ,BCOP,BTgr,BTgo,BRr,BRgr,Btp,Btg,BL")] Baza baza)
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
            Baza model = new Baza();
            List<ZmiennaItem> zmienne = model.Zmienne;
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,DATA,Nazwa,Opis,RQg,RFi,RQ0,RDz,Rtinf,Rt,RL,KQc,KCOP,KQ0,KH,KZ,KB,KTgr,DT,KTgm,Ktp,Kalfag,Kalfap,KAgr,Agr,KAr,Kdw,Kdz,KK,KC,KqL,Kqh,Kep,KLp,SQv,SLo,SLw,SdLw,SQc,SCOP,STsp,SQ0,BDz,BDw,Blambdar,Bn,Bgamma,BQ,BCOP,BTgr,BTgo,BRr,BRgr,Btp,Btg,BL")] Baza baza)
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
            Baza model = new Baza();
            List<ZmiennaItem> zmienne = model.Zmienne;
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
