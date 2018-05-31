using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Web.Data;
using ManagementSystem.Web.ViewModels;

namespace ManagementSystem.Web.Pages.Finance.OperationCost
{
    public class IndexModel : PageModel
    {
        private readonly ManagementSystem.Web.Data.ApplicationDbContext _context;

        public IndexModel(ManagementSystem.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Data.OperationCost> OperationCosts { get; set; }
        public List<UsedBudgetChartModel> UsedBudgetChartModelList { get; set; } = new List<UsedBudgetChartModel>();
        public async Task OnGetAsync(int? year)
        {
            if (!year.HasValue)
            {
                year = DateTime.Now.Year;
            }
            OperationCosts = await _context.OperationCosts
                .Where(cost => cost.Time.Year == year.Value)
                .ToListAsync();

            for (int i = 0; i <= 11; i++)
            {
                UsedBudgetChartModelList.Add(new UsedBudgetChartModel()
                {
                    Amount = 0
                });
            }

            foreach(var cost in OperationCosts)
            {
                UsedBudgetChartModelList[cost.Time.Month - 1].Amount += cost.Amount;
            }
        }
    }
}
