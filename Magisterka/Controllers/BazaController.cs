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
            return View();
        }

        // POST: Baza/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // ("Id,RQg,RFi,Rro,RQ0,RXo,RDz,Rtinf,Rt,RL,KQc,KCOP,KQ0,KH,KZ,KB,KTgr,DT,KTgm,Ktp,Kalfag,Kalfap,KAgr,Agr,KAr,Kdw,Kdz,KK,KC,KqL,Kqh,Kep,KLp")
        //TYLKO DATA,Nazwa,Opis wymagane powinny byc
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DATA,Nazwa,Opis,RQg,RFi,Rro,RQ0,RXo,RDz,Rtinf,Rt,RL,KQc,KCOP,KQ0,KH,KZ,KB,KTgr,DT,KTgm,Ktp,Kalfag,Kalfap,KAgr,Agr,KAr,Kdw,Kdz,KK,KC,KqL,Kqh,Kep,KLp")] Baza baza)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,RQg,RFi,Rro,RQ0,RXo,RDz,Rtinf,Rt,RL,KQc,KCOP,KQ0,KH,KZ,KB,KTgr,DT,KTgm,Ktp,Kalfag,Kalfap,KAgr,Agr,KAr,Kdw,Kdz,KK,KC,KqL,Kqh,Kep,KLp")] Baza baza)
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
