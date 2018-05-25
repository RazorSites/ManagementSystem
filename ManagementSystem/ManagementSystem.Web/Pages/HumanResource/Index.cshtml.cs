using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManagementSystem.Web.Pages.HumanResource
{
    public class IndexModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public IndexModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public int CountEmployees { get; set; }
        public int CountComplaints { get; set; }

        public void OnGet()
        {
            SidebarManager.OnPage(Pages.Page.Personnel);

            CountEmployees = _context.ApplicationUsers.Count();
            CountComplaints = _context.Complaints.Count();
        }

    }
}