using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eManagement.Data;
using eManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace eManagement.Controllers
{
    [Authorize(Roles="Admin")]
    public class eManagementLeadController : Controller
    {
        private readonly ApplicationDbContex _context;

        public eManagementLeadController(ApplicationDbContex context)
        {
            _context = context;
        }

        // GET: eManagementLead
        public async Task<IActionResult> Index()
        {
            return View(await _context.eManagementLeadEntity.ToListAsync());
        }

        // GET: eManagementLead/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eManagementLeadEntity = await _context.eManagementLeadEntity
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eManagementLeadEntity == null)
            {
                return NotFound();
            }

            return View(eManagementLeadEntity);
        }

        // GET: eManagementLead/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: eManagementLead/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Mobile,Email,Setor,Source")] eManagementLeadEntity eManagementLeadEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eManagementLeadEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eManagementLeadEntity);
        }

        // GET: eManagementLead/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eManagementLeadEntity = await _context.eManagementLeadEntity.FindAsync(id);
            if (eManagementLeadEntity == null)
            {
                return NotFound();
            }
            return View(eManagementLeadEntity);
        }

        // POST: eManagementLead/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Mobile,Email,Setor,Source")] eManagementLeadEntity eManagementLeadEntity)
        {
            if (id != eManagementLeadEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eManagementLeadEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!eManagementLeadEntityExists(eManagementLeadEntity.Id))
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
            return View(eManagementLeadEntity);
        }

        // GET: eManagementLead/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eManagementLeadEntity = await _context.eManagementLeadEntity
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eManagementLeadEntity == null)
            {
                return NotFound();
            }

            return View(eManagementLeadEntity);
        }

        // POST: eManagementLead/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eManagementLeadEntity = await _context.eManagementLeadEntity.FindAsync(id);
            if (eManagementLeadEntity != null)
            {
                _context.eManagementLeadEntity.Remove(eManagementLeadEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool eManagementLeadEntityExists(int id)
        {
            return _context.eManagementLeadEntity.Any(e => e.Id == id);
        }
    }
}
