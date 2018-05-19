using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.Finance.AllowanceSalary
{
    public class EditModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public EditModel(ManagementSystem.Web.Data.ApplicationDbContext context)
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
           ViewData["AllowanceId"] = new SelectList(_context.Allowwances, "Id", "Id");
           ViewData["ApplicationUserId"] = new SelectList(_context.Salaries, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AllowanceSalary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllowanceSalaryExists(AllowanceSalary.Id))
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

        private bool AllowanceSalaryExists(Guid id)
        {
            return _context.AllowanceSalaries.Any(e => e.Id == id);
        }
    }
}
