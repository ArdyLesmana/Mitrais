using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Mitrais_Test_Core.Helper;
using Mitrais_Test_Core.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Mitrais_Test_Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            JsonEntity _json = new JsonEntity();
            var modelState = context.ModelState;

            if (!modelState.IsValid)
            {
                var errors = modelState.Where(n => n.Value.Errors.Count > 0).ToList();
                string errorMessage = "";
                if (errors.Count > 0)
                {
                    foreach (var error in errors)
                    {
                        errorMessage += error.Value.Errors[0].ErrorMessage + " ";
                    }

                    errorMessage.Remove(errorMessage.Length - 1);

                    _json.AddErrorAlert(((int)HttpStatusCode.BadRequest).ToString(), errorMessage.Replace(".", ","));
                }
                else
                {
                    _json.AddErrorAlert(HttpStatusCode.BadRequest, BaseApiMessage.ERROR_COMMON_INVALID_PARAMETER);
                }
                context.Result = new JsonResult(_json, new JsonSerializerSettings()
                {
                    ContractResolver = new DefaultJsonContactResolver()
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    }
                });
                return;
            }
            base.OnActionExecuting(context);
        }
    }
}
