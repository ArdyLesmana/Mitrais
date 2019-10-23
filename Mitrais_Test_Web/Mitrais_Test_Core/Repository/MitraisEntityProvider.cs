using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Core.Repository
{
    public class MitraisEntityProvider
    {
        protected readonly string connString;
        public MitraisEntityProvider(string _connString)
        {
            connString = _connString;
        }
    }
}
