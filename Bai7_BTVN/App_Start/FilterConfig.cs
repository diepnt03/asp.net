﻿using System.Web;
using System.Web.Mvc;

namespace Bai7_BTVN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
