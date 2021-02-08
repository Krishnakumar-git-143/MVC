using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NtireArchitecturewithAdo.Data;
using NtireArchitecturewithAdo.Models;

namespace NtireArchitecturewithAdo.Controllers
{
    public class BanksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BanksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Banks
        public IActionResult Index()
        {
            Getdetails bal = new Getdetails();

            var details = bal.GetBanks();


            IList<Banks> banks = new List<Banks>();
            foreach (DataRow row in details.Tables[0].Rows)
            {
                Banks bank = new Banks()
                {
                    BankId = int.Parse(row["BankId"].ToString()),
                    BankName = row["BankName"].ToString(),
                    BankAddress = row["BankAddress"].ToString(),
                };
                banks.Add(bank);
            }
            return View(banks);
        }


        // GET: Banks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banks = await _context.Banks
                .FirstOrDefaultAsync(m => m.BankId == id);
            if (banks == null)
            {
                return NotFound();
            }

            return View(banks);
        }

        // GET: Banks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Banks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BankId,BankName,BankAddress")] Banks banks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(banks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banks);
        }

        // GET: Banks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banks = await _context.Banks.FindAsync(id);
            if (banks == null)
            {
                return NotFound();
            }
            return View(banks);
        }

        // POST: Banks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BankId,BankName,BankAddress")] Banks banks)
        {
            if (id != banks.BankId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(banks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BanksExists(banks.BankId))
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
            return View(banks);
        }

        // GET: Banks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banks = await _context.Banks
                .FirstOrDefaultAsync(m => m.BankId == id);
            if (banks == null)
            {
                return NotFound();
            }

            return View(banks);
        }

        // POST: Banks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var banks = await _context.Banks.FindAsync(id);
            _context.Banks.Remove(banks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BanksExists(int id)
        {
            return _context.Banks.Any(e => e.BankId == id);
        }
    }
}
