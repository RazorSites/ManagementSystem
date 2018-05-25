using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Web.Pages.HumanResource.Complaint
{
    public class Util
    {
        public static Data.Complaint complaintHandling;

        public static string myEmail;

        public static string FuckOff(Data.Complaint complaint) // What the fuck name? Anyone say why? 
        {
            complaintHandling = complaint;

            return "";
        }
    }
}
