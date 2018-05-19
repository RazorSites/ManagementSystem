using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.Finance.AllowanceSalary
{
    public class DeleteModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public DeleteModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Data.AllowanceSalary AllowanceSalary { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AllowanceSalary = await _context.AllowanceSalaries
                .Include(a => a.Allowance)
                .Include(a => a.ApplicationUser).SingleOrDefaultAsync(m => m.Id == id);

            if (AllowanceSalary == null)
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

            AllowanceSalary = await _context.AllowanceSalaries.FindAsync(id);

            if (AllowanceSalary != null)
            {
                _context.AllowanceSalaries.Remove(AllowanceSalary);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
