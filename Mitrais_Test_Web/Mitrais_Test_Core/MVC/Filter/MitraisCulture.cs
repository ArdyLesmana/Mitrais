using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Mitrais_Test_Core.MVC.Filter
{
    public class MitraisCulture : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string culture = "en";
            try
            {
                context.HttpContext.Request.Headers["language"].ToString();
            }
            catch { }
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            CultureInfo.CurrentUICulture = new CultureInfo(culture);

            base.OnActionExecuting(context);
        }
    }
}
