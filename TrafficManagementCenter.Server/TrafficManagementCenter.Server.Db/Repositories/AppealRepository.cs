using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class AppealRepository : IRepository<Appeal>
    {
        private readonly AppDbContext _context;

        public AppealRepository(AppDbContext context)
        {
            _context = context;
        }

        public Appeal Get(long id)
        {
            return _context.Appeal.FirstOrDefault(p => p.Key.Equals(id));
        }

        public IEnumerable<Appeal> GetEntities()
        {
            return _context.Appeal;
        }
        
        public IEnumerable<Appeal> GetEntitiesByEmail(string email)
        {
            return _context.Appeal.Where(p=> p.Email.Equals(email));
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
    }
}