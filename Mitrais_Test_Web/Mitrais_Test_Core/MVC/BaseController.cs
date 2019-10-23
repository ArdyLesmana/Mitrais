using Microsoft.AspNetCore.Mvc;
using Mitrais_Test_Core.Helper;
using Mitrais_Test_Core.MVC.Filter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Core.MVC
{
    [ServiceFilter(typeof(MitraisCulture))]
    public class BaseController : Controller
    {
        public JsonResult Json(object data, JsonFormatType format = JsonFormatType.FormatOutput)
        {
            if (format == JsonFormatType.FormatOutput)
            {
                return base.Json(data, new JsonSerializerSettings() { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore, ContractResolver = new JsonLowerCaseUnderscoreContractResolver() });
            }
            else
            {
                return base.Json(data);
            }
        }

        public override JsonResult Json(object data, JsonSerializerSettings serializerSettings)
        {
            return base.Json(data, serializerSettings);
        }
    }
}
