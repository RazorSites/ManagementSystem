using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.Finance.OperationCost
{
    public class DeleteModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public DeleteModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Data.OperationCost OperationCost { get; set; }

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

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OperationCost = await _context.OperationCosts.FindAsync(id);

            if (OperationCost != null)
            {
                _context.OperationCosts.Remove(OperationCost);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
