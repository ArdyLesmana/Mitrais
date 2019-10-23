using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mitrais_Test_Core.Helper
{
    public class JsonLowerCaseUnderscoreContractResolver : DefaultContractResolver
    {
        private Regex regex = new Regex("(?!(^[A-Z]))([A-Z])");

        protected override string ResolvePropertyName(string propertyName)
        {
            return regex.Replace(propertyName, "_$2").ToLower();
        }
    }
}
