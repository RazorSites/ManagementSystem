using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ManagementSystem.Web.Data;
using Microsoft.AspNetCore.Http;

namespace ManagementSystem.Web.Pages.Product.Build
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

        public IActionResult OnGet(Guid productId)
        {
            this.ProductId = productId;
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Data.Build Build { get; set; }

        public Guid ProductId { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var productId = Guid.Parse(httpContextAccessor.HttpContext.Request.Query["productId"].ToString());
            Build.ProductId = productId;
            _context.Builds.Add(Build);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Product/Details", new { id = productId});
        }
    }
}