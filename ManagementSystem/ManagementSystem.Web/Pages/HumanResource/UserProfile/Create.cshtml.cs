using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.HumanResource.UserProfile
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
            ViewData["JobPosition"] = new SelectList(_context.JobPositions, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ApplicationUsers.Add(ApplicationUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}