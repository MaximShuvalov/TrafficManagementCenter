using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class TypeAppealRepository : IRepository<TypeAppeal>
    {
        private AppDbContext _context;
        public TypeAppeal Get(long id)
        {
            using (_context = new AppDbContext())
                return _context.TypeAppeal.FirstOrDefault(p=> p.Key.Equals(id));
        }

        public IEnumerable<TypeAppeal> GetEntities()
        {
            using (_context = new AppDbContext())
                return _context.TypeAppeal;
        }

        public void Add(TypeAppeal entity)
        {
            if(entity is null)
                throw new ArgumentException("TypeAppeal is null");
            using (_context = new AppDbContext())
            {
                _context.TypeAppeal.Add(entity);
                _context.SaveChanges();
            }
        }
    }
}