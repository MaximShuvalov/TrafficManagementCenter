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
        private SubtypeAppealContext _context;

        public SubtypeAppeal Get(long id)
        {
            using (_context = new SubtypeAppealContext())
                return _context.SubtypesAppeals.FirstOrDefault(o => o.Key.Equals(id));
        }

        public IEnumerable<SubtypeAppeal> GetEntities()
        {
            using (_context = new SubtypeAppealContext())
                return _context.SubtypesAppeals;
        }

        public void Add(SubtypeAppeal entity)
        {
            if (entity is null)
                throw new ArgumentException("SubtypeAppeal is null");
            using (_context = new SubtypeAppealContext())
            {
                _context.SubtypesAppeals.Add(entity);
                _context.SaveChanges();
            }
        }
    }
}