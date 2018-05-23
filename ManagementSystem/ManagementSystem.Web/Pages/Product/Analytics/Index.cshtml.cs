using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Web.Pages.Product.Analytics
{
    public class IndexModel : PageModel
    {
        private readonly Data.ApplicationDbContext dbContext;

        public List<Data.Product> Products { get; set; }

        public List<ProjectByMonthChartModel> ProjectByMonthChartModelList { get; set; } = new List<ProjectByMonthChartModel>();

        public IndexModel(Data.ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnGet(int? year)
        {
            Products = dbContext.Products
               .Include(p => p.Builds)
               .Where(p => p.Created.Year == 2018)
               .ToList();

            for (int i = 0; i <= 11; i++)
            {
                ProjectByMonthChartModelList.Add(new ProjectByMonthChartModel());
            }

            foreach(var product in Products)
            {
                ProjectByMonthChartModelList[product.Created.Month - 1].NumberOfProducts += 1;
            }
        }
    }
}