using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Web.Pages.Finance
{
    public class IndexModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public IndexModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Data.OperationCost> OperationCost { get; set; }

        public async Task OnGetAsync()
        {
            SidebarManager.OnPage(Pages.Page.Finance);

            OperationCost = await _context.OperationCosts.ToListAsync();
        }
    }
}