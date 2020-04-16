using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Agrimada.Memberspace.Data;
using Agrimada.Memberspace.Models;
using Agrimada.Shared.Models;

namespace Agrimada.Memberspace.Controllers
{
    public class SupplierProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SupplierProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SupplierProducts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SupplierProducts.Include(s => s.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SupplierProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierProduct = await _context.SupplierProducts
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplierProduct == null)
            {
                return NotFound();
            }

            return View(supplierProduct);
        }

        // GET: SupplierProducts/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // POST: SupplierProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,ProductId,Quantity,Id")] SupplierProduct supplierProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", supplierProduct.ProductId);
            return View(supplierProduct);
        }

        // GET: SupplierProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierProduct = await _context.SupplierProducts.FindAsync(id);
            if (supplierProduct == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", supplierProduct.ProductId);
            return View(supplierProduct);
        }

        // POST: SupplierProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierId,ProductId,Quantity,Id")] SupplierProduct supplierProduct)
        {
            if (id != supplierProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierProductExists(supplierProduct.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", supplierProduct.ProductId);
            return View(supplierProduct);
        }

        // GET: SupplierProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierProduct = await _context.SupplierProducts
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplierProduct == null)
            {
                return NotFound();
            }

            return View(supplierProduct);
        }

        // POST: SupplierProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplierProduct = await _context.SupplierProducts.FindAsync(id);
            _context.SupplierProducts.Remove(supplierProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }                   

        private bool SupplierProductExists(int id)
        {
            return _context.SupplierProducts.Any(e => e.Id == id);
        }
    }
}
