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
        private AppDbContext _context;

        public Appeal Get(long id)
        {
            using (_context = new AppDbContext())
                return _context.Appeal.FirstOrDefault(p => p.Key.Equals(id));
        }

        public Task<IEnumerable<Appeal>> GetEntities()
        {
            return new Task<IEnumerable<Appeal>>(() =>
            {
                using (_context = new AppDbContext())
                    return _context.Appeal;
            });
            //IEnumerable<Appeal> appeals;
            //using (_context = new AppDbContext())
            //     appeals = _context.Appeal;
            //return appeals;
        }

        public void Add(Appeal entity)
        {
            if (entity is null)
                throw new ArgumentException("Appeal is null");
            using (_context = new AppDbContext())
            {
                _context.Appeal.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(Appeal entity)
        {
            if (entity is null)
                throw new ArgumentException("Appeal is null");
            using (_context = new AppDbContext())
            {
                _context.Appeal.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}