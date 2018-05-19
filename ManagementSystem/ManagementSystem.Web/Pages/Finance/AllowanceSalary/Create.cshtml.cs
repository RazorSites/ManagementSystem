using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.Finance.AllowanceSalary
{
    public class CreateModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public CreateModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AllowanceId"] = new SelectList(_context.Allowwances, "Id", "Id");
        ViewData["ApplicationUserId"] = new SelectList(_context.Salaries, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Data.AllowanceSalary AllowanceSalary { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AllowanceSalaries.Add(AllowanceSalary);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}