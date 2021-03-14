using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class ClassAppealsRepository : IRepository<ClassAppeal>
    {
        private readonly AppDbContext _context;

        public ClassAppealsRepository(AppDbContext context)
        {
            _context = context;
        }

        public ClassAppeal Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClassAppeal> GetEntities() => _context.ClassAppeal;

        public void Add(ClassAppeal entity)
        {
            if (entity is null)
                throw new ArgumentException("ClassAppeal is null");
            if (_context.ClassAppeal.Contains(entity))
                return;
            _context.ClassAppeal.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(ClassAppeal entity)
        {
            if (entity is null)
                throw new ArgumentException("ClassAppeal is null");
            _context.ClassAppeal.Remove(entity);
            _context.SaveChanges();
        }
    }
}