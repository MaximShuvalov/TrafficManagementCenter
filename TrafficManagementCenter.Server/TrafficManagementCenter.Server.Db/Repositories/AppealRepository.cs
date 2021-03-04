using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class AppealRepository : IRepository<Appeal>, IDisposable
    {
        private readonly AppDbContext _context = new AppDbContext();

        public Appeal Get(long id)
        {
            return _context.Appeal.FirstOrDefault(p => p.Key.Equals(id));
        }

        public IEnumerable<Appeal> GetEntities()
        {
            return _context.Appeal;
        }

        public void Add(Appeal entity)
        {
            if (entity is null)
                throw new ArgumentException("Appeal is null");
            _context.Appeal.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Appeal entity)
        {
            if (entity is null)
                throw new ArgumentException("Appeal is null");
            _context.Appeal.Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}