using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public interface IRepository<T>
    {
        T Get(long id);

        IEnumerable<T> GetEntities();

        void Add(T entity);

        void Delete(T entity);
    }
}