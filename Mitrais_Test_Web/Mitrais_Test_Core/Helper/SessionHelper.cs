using Mitrais_Test_Core.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Mitrais_Test_Core.Helper
{
    public static class SessionHelper
    {
        public static SystemInfo Info
        {
            get
            {
                SystemInfo system = new SystemInfo()
                {
                    Language = CultureInfo.CurrentCulture.ToString()
                };
                return system;
            }
        }
    }
}
