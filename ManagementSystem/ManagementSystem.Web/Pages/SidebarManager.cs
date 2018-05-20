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
        public static bool isOnPersonnel;


        public static void OnPage(Page page)
        {
            isOnDashboard = false;
            isOnFinance = false;
            isOnPersonnel = false;

            switch (page)
            {
                case Page.Dashboard:
                    isOnDashboard = true;
                    break;
                case Page.Finance:
                    isOnFinance = true;
                    break;
                case Page.Personnel:
                    isOnPersonnel = true;
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
                case Page.Personnel:
                    return isOnPersonnel == true ? "active" : "";

                default:
                    break;
            }

            return "";
        }
    }

    public enum Page {
        Dashboard,
        Personnel,
        Finance
    };
}
