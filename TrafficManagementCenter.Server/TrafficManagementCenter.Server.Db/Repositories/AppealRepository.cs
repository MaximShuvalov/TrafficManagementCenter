using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class AppealRepository : IRepository<Appeal>
    {
        public Appeal Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Appeal> GetEntities()
        {
            throw new System.NotImplementedException();
        }

        public Task Add(Appeal entity)
        {
            throw new System.NotImplementedException();
        }
    }
}