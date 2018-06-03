using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ManagementSystem.Web.Data;
using Microsoft.AspNetCore.Http;

namespace ManagementSystem.Web.Pages.Product.Report
{
    public class CreateModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;
        private readonly IHttpContextAccessor httpContextAccessor;

        public CreateModel(ManagementSystem.Web.Data.ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this.httpContextAccessor = httpContextAccessor;
        }

        public IActionResult OnGet(Guid buildId)
        {
        ViewData["BuildId"] = new SelectList(_context.Builds, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Data.Report Report { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var buildId = Guid.Parse(httpContextAccessor.HttpContext.Request.Query["buildId"].ToString());
            Report.BuildId = buildId;
            _context.Reports.Add(Report);
            await _context.SaveChangesAsync();

            var productId = _context.Builds.Where(b => b.Id == buildId).Select(b => b.ProductId);
            return RedirectToPage("/Product/Details", new { id = productId });
        }
    }
}