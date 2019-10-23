using NPoco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Mitrais_Test_Core.Repository
{
    public class MitraisEntity
    {
        private readonly Transaction _petaTransaction;
        private readonly Database _db;

        public MitraisEntity(string connString)
        {
            _db = new Database(connString, DatabaseType.SqlServer2012, SqlClientFactory.Instance);
            _petaTransaction = new Transaction(_db, System.Data.IsolationLevel.ReadCommitted);
            IsRollback = false;
        }

        public void Dispose()
        {
            if (!IsRollback)
            {
                _petaTransaction.Complete();
            }
            _petaTransaction.Dispose();
        }

        public Database Db
        {
            get { return _db; }
        }

        public bool IsRollback { get; set; }

        public void Commit()
        {
            _petaTransaction.Complete();
        }
    }
}
