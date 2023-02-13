using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCRoseNoirDatabase.Data;
using MVCRoseNoirDatabase.Models;

namespace MVCRoseNoirDatabase.Controllers
{
    public class PaymentCardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PaymentCards
        public async Task<IActionResult> Index()
        {
              return _context.Paymentcard != null ? 
                          View(await _context.Paymentcard.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Paymentcard'  is null.");
        }

        // GET: PaymentCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Paymentcard == null)
            {
                return NotFound();
            }

            var paymentCard = await _context.Paymentcard
                .FirstOrDefaultAsync(m => m.PaymentCardId == id);
            if (paymentCard == null)
            {
                return NotFound();
            }

            return View(paymentCard);
        }

        // GET: PaymentCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentCardId,PaymentType,Bank,CardNumber,NameOnCard,ExpiryYear,ExpiryMonth")] PaymentCard paymentCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentCard);
        }

        // GET: PaymentCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Paymentcard == null)
            {
                return NotFound();
            }

            var paymentCard = await _context.Paymentcard.FindAsync(id);
            if (paymentCard == null)
            {
                return NotFound();
            }
            return View(paymentCard);
        }

        // POST: PaymentCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaymentCardId,PaymentType,Bank,CardNumber,NameOnCard,ExpiryYear,ExpiryMonth")] PaymentCard paymentCard)
        {
            if (id != paymentCard.PaymentCardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentCardExists(paymentCard.PaymentCardId))
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
            return View(paymentCard);
        }

        // GET: PaymentCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Paymentcard == null)
            {
                return NotFound();
            }

            var paymentCard = await _context.Paymentcard
                .FirstOrDefaultAsync(m => m.PaymentCardId == id);
            if (paymentCard == null)
            {
                return NotFound();
            }

            return View(paymentCard);
        }

        // POST: PaymentCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Paymentcard == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Paymentcard'  is null.");
            }
            var paymentCard = await _context.Paymentcard.FindAsync(id);
            if (paymentCard != null)
            {
                _context.Paymentcard.Remove(paymentCard);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentCardExists(int id)
        {
          return (_context.Paymentcard?.Any(e => e.PaymentCardId == id)).GetValueOrDefault();
        }
    }
}
