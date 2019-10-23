using Mitrais_Test_Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mitrais_Test_Repo.UnitOfWork
{
    public class DBEntity : MitraisEntity, IDBEntity
    {
        public DBEntity(string connString) : base(connString) { }
    }
}
