﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManagementSystem.Web.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            SidebarManager.OnPage(Pages.Page.Dashboard);
        }
    }
}
