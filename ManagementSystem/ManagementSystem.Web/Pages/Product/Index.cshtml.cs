using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManagementSystem.Web.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly Data.ApplicationDbContext dbContext;

        public List<Data.Product> Products { get; set; }

        public IndexModel(Data.ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnGet()
        {
            Products = dbContext.Products.ToList();
        }
    }
}