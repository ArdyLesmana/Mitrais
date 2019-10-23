using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Mitrais_Test_Core.Repository
{
    public class BaseRepository<T> : IRepository<T>
    {
        private string tName = typeof(T).Name;

        public virtual T FindById(IMitraisEntity mitraisEntity, object id)
        {
            try
            {
                return mitraisEntity.Db.FirstOrDefault<T>("where " + tName + "Id=@0", id.ToString());
                //repo.FindById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public virtual T FindByCondition(IMitraisEntity mitraisEntity, string where, params object[] args)
        {
            try
            {
                string query = "";
                if (where.ToLower().Contains("select"))
                    query = where;
                else
                    query = "select * from [" + tName + "] " + where;

                return mitraisEntity.Db.SingleOrDefault<T>(query, args);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public virtual O FindByCondition<O>(IMitraisEntity mitraisEntity, string where, params object[] args)
        {
            try
            {
                return mitraisEntity.Db.SingleOrDefault<O>(where, args);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public virtual List<T> FindAllByCondition(IMitraisEntity mitraisEntity, string where, params object[] args)
        {
            try
            {
                return mitraisEntity.Db.Fetch<T>(where, args);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public virtual List<O> FindAllByCondition<O>(IMitraisEntity mitraisEntity, string where, params object[] args)
        {
            try
            {
                return mitraisEntity.Db.Fetch<O>(where, args);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public virtual int Count(IMitraisEntity mitraisEntity, string where, params object[] args)
        {
            try
            {
                string query = "";
                if (where.ToLower().Contains("select"))
                    query = where;
                else
                    query = "select count(1) as [TotalCount] from [" + tName + "] " + where;

                return mitraisEntity.Db.SingleOrDefault<int>(query, args);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public virtual int Insert(IMitraisEntity mitraisEntity, string primaryKeyName, T entity)
        {
            int output = 0;
            try
            {
                mitraisEntity.Db.Insert<T>(tName, primaryKeyName, true, entity);
            }
            catch (Exception ex)
            {
                output = -1;
                throw ex;
                //throw new exception(ex.message.tostring());
            }
            return output;
        }


        public virtual int Update(IMitraisEntity mitraisEntity, string primaryKeyName, T entity)
        {
            int output = 0;
            try
            {
                output = mitraisEntity.Db.Update(tName, primaryKeyName, entity);
            }
            catch (Exception ex)
            {
                output = -1;
                throw new Exception(ex.Message.ToString());
            }
            return output;
        }

        public virtual int Delete(IMitraisEntity mitraisEntity, object id)
        {
            int output = 0;
            try
            {
                T obj = mitraisEntity.Db.FirstOrDefault<T>("where " + tName + "Id=@0", id.ToString());
                if (obj != null)
                {
                    output = mitraisEntity.Db.Delete<T>(id);
                }
            }
            catch (Exception ex)
            {
                output = -1;
                throw new Exception(ex.Message.ToString());
            }
            return output;
        }

        public virtual int Delete(IMitraisEntity mitraisEntity, string where, params object[] args)
        {
            int output = 0;
            try
            {
                T obj = mitraisEntity.Db.FirstOrDefault<T>(where, args);
                if (obj != null)
                {
                    output = mitraisEntity.Db.Delete<T>(obj);
                }
            }
            catch (Exception ex)
            {
                output = -1;
                throw new Exception(ex.Message.ToString());
            }

            return output;
        }


        public virtual int Delete(IMitraisEntity mitraisEntity, string tableName, object param)
        {
            int output = 0;
            try
            {
                T obj = mitraisEntity.Db.Query<T>("Where " + tableName + " = @0", param).SingleOrDefault();
                if (obj != null)
                {
                    output = mitraisEntity.Db.Delete<T>(obj);
                }
            }
            catch (Exception ex)
            {
                output = -1;
                throw new Exception(ex.Message.ToString());
            }

            return output;
        }

        public virtual int ExeNonQuery(IMitraisEntity mitraisEntity, string sql, params object[] args)
        {
            int output = 0;
            try
            {
                output = mitraisEntity.Db.Execute(sql, args);
            }
            catch (Exception ex)
            {
                output = -1;
                throw new Exception(ex.Message.ToString());
            }
            return output;
        }

        public virtual int ExeNonQuery(IMitraisEntity mitraisEntity, string sql, CommandType commandType, params object[] args)
        {
            int output = 0;
            try
            {
                output = mitraisEntity.Db.Execute(sql, args, commandType);
            }
            catch (Exception ex)
            {
                output = -1;
                throw new Exception(ex.Message.ToString());
            }
            return output;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }


                disposedValue = true;
            }
        }



        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
        }



        #endregion
    }
}
