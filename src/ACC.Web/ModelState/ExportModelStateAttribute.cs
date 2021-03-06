﻿using System;
using System.Web.Mvc;

namespace ACC.Web.ModelState
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ExportModelStateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var filter = new ExportModelStateFilter();
            filter.OnActionExecuted(filterContext);
        }
    }
}