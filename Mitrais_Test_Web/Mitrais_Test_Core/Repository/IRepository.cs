using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Mitrais_Test_Core.Repository
{
    public interface IRepository<T> : IDisposable
    {
        T FindById(IMitraisEntity mitraisEntity, object id);

        T FindByCondition(IMitraisEntity mitraisEntity, string where, params object[] args);

        O FindByCondition<O>(IMitraisEntity mitraisEntity, string where, params object[] args);

        List<T> FindAllByCondition(IMitraisEntity mitraisEntity, string where, params object[] args);

        List<O> FindAllByCondition<O>(IMitraisEntity mitraisEntity, string where, params object[] args);

        /// Return count value 
        int Count(IMitraisEntity mitraisEntity, string where, params object[] args);

        int Insert(IMitraisEntity mitraisEntity, string primaryKeyName, T entity);

        int Update(IMitraisEntity mitraisEntity, string primaryKeyName, T entity);

        int Delete(IMitraisEntity mitraisEntity, object id);

        int Delete(IMitraisEntity mitraisEntity, string where, params object[] args);

        int ExeNonQuery(IMitraisEntity mitraisEntity, string sql, params object[] args);

        int ExeNonQuery(IMitraisEntity mitraisEntity, string sql, CommandType commandType, params object[] args);

        int Delete(IMitraisEntity mitraisEntity, string tableName, object param);
    }
}
