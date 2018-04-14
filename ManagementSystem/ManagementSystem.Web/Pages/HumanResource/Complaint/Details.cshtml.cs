using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.HumanResource.Complaint
{
    public class DetailsModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public DetailsModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Data.Complaint Complaint { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Complaint = await _context.Complaints
                .Include(c => c.ApplicationUser).SingleOrDefaultAsync(m => m.Id == id);

            if (Complaint == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
