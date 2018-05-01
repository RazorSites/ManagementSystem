using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Web.Pages
{
    public static class SidebarManager
    {
        public static bool isOnDashboard;
        public static bool isOnFinance;

        public static void OnPage(Page page)
        {
            switch (page)
            {
                case Page.Dashboard:
                    isOnDashboard = true;
                    isOnFinance = false;
                    break;
                case Page.Finance:
                    isOnDashboard = false;
                    isOnFinance = true;
                    break;
                default:
                    break;
            }
        }

        public static String GetClass(Page page)
        {
            switch (page)
            {
                case Page.Dashboard:
                    return isOnDashboard == true ? "active" : "";
                case Page.Finance:
                    return isOnFinance == true ? "active" : "";
                default:
                    break;
            }

            return "";
        }
    }

    public enum Page {
        Dashboard,
        Finance
    };
}
