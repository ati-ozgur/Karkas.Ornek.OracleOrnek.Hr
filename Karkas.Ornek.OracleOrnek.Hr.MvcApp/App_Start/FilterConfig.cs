﻿using System.Web;
using System.Web.Mvc;

namespace Karkas.Ornek.OracleOrnek.Hr.MvcApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}