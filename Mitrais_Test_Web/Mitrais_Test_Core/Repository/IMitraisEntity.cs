using NPoco;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Core.Repository
{
    public interface IMitraisEntity : IDisposable
    {
        void Commit();
        Database Db { get; }
        bool IsRollback { get; set; }
    }
}
