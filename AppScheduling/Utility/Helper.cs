using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppScheduling.Utility

{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Docter = "Docter";

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Value=Helper.Admin, Text=Helper.Admin},
                new SelectListItem{ Value=Helper.Patient, Text=Helper.Patient},
                new SelectListItem{ Value=Helper.Docter, Text=Helper.Docter}
            };
        }
    }
}
