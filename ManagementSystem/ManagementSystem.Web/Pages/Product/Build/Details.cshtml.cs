using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.Product.Build
{
    public class DetailsModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public DetailsModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Data.Build Build { get; set; }

        public List<Data.Report> Reports { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Build = await _context.Builds
                .Include(b => b.Product).SingleOrDefaultAsync(m => m.Id == id);

            Reports = _context.Reports
                .Where(r => r.BuildId == Build.Id).ToList();

            if (Build == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
