using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.Finance
{
    public class EditModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public EditModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OperationCost OperationCost { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OperationCost = await _context.OperationCosts.SingleOrDefaultAsync(m => m.Id == id);

            if (OperationCost == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OperationCost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperationCostExists(OperationCost.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OperationCostExists(Guid id)
        {
            return _context.OperationCosts.Any(e => e.Id == id);
        }
    }
}
