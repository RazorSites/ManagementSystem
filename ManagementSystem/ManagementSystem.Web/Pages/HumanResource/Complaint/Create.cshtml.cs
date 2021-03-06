﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Pages.HumanResource.Complaint
{
    public class CreateModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public CreateModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Data.Complaint Complaint { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Complaints.Add(Complaint);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public Data.ApplicationUser CurrentUser { get; set; }

        public IActionResult OnGet()
        {
            CurrentUser = _context.ApplicationUsers.FirstOrDefault(u => u.Email == Util.myEmail);

            return Page();
        }

    }
}