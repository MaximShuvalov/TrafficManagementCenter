using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class SubtypeAppealRepository : IRepository<SubtypeAppeal>
    {
        private AppDbContext _context;

        public SubtypeAppeal Get(long id)
        {
            using (_context = new AppDbContext())
                return _context.SubtypeAppeals.FirstOrDefault(o => o.Key.Equals(id));
        }

        public IEnumerable<SubtypeAppeal> GetEntities()
        {
            using (_context = new AppDbContext())
                return _context.SubtypeAppeals;
        }

        public void Add(SubtypeAppeal entity)
        {
            if (entity is null)
                throw new ArgumentException("SubtypeAppeal is null");
            using (_context = new AppDbContext())
            {
                _context.SubtypeAppeals.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(SubtypeAppeal entity)
        {
            if (entity is null)
                throw new ArgumentException("SubtypeAppeal is null");
            using (_context = new AppDbContext())
            {
                _context.SubtypeAppeals.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}