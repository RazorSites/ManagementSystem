using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.Finance
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
            return Page();
        }

        [BindProperty]
        public OperationCost OperationCost { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OperationCosts.Add(OperationCost);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}