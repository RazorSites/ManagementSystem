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
    public class IndexModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public IndexModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Data.Complaint> Complaint { get; set; }

        public async Task OnGetAsync()
        {
            Complaint = await _context.Complaints
                .Include(c => c.ApplicationUser).ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Util.complaintHandling.IsReviewed = true;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Util.complaintHandling).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplaintExists(Util.complaintHandling.Id))
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

        private bool ComplaintExists(Guid id)
        {
            return _context.Complaints.Any(e => e.Id == id);
        }

    }
}
