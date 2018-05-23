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
        public static bool isOnProduct;

        public static void OnPage(Page page)
        {
            switch (page)
            {
                case Page.Dashboard:
                    isOnDashboard = true;
                    isOnFinance = false;
                    isOnProduct = false;
                    break;
                case Page.Finance:
                    isOnDashboard = false;
                    isOnFinance = true;
                    isOnProduct = false;
                    break;
                case Page.Product:
                    isOnProduct = true;
                    isOnDashboard = false;
                    isOnFinance = false;
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
                case Page.Product:
                    return isOnProduct == true ? "active" : "";
                default:
                    break;
            }

            return "";
        }
    }

    public enum Page {
        Dashboard,
        Finance,
        Product
    };
}
