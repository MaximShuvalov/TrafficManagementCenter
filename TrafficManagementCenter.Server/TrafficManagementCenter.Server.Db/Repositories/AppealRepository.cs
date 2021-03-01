using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class AppealRepository : IRepository<Appeal>
    {
        private AppealContext _context;

        public Appeal Get(long id)
        {
            using (_context = new AppealContext())
                return _context.TypeAppeal.FirstOrDefault(p => p.Key.Equals(id));
        }

        public IEnumerable<Appeal> GetEntities()
        {
            using (_context = new AppealContext())
                return _context.TypeAppeal;
        }

        public void Add(Appeal entity)
        {
            if (entity is null)
                throw new ArgumentException("Appeal is null");
            using (_context = new AppealContext())
            {
                _context.TypeAppeal.Add(entity);
                _context.SaveChanges();
            }
        }
    }
}