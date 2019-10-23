using Mitrais_Test_Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Repo.UnitOfWork
{
    public class DBEntityProvider : MitraisEntityProvider, IDBEntityProvider
    {
        public DBEntityProvider(string _connString) : base(_connString) { }

        public IMitraisEntity GetMitraisEntity()
        {
            return new DBEntity(connString);
        }
    }
}
