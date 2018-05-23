using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.Finance.AllowanceSalary
{
    public class IndexModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public IndexModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Data.AllowanceSalary> AllowanceSalary { get;set; }

        public async Task OnGetAsync()
        {
            AllowanceSalary = await _context.AllowanceSalaries
                .Include(a => a.Allowance)
                .Include(a => a.Salary).ToListAsync();
        }
    }
}
