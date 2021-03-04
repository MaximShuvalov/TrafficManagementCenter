using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class TypeAppealRepository : IRepository<TypeAppeal>
    {
        private readonly AppDbContext _context;

        public TypeAppealRepository(AppDbContext context)
        {
            _context = context;
        }
        public TypeAppeal Get(long id) => _context.TypeAppeal.FirstOrDefault(p => p.Key.Equals(id));

        public IEnumerable<TypeAppeal> GetEntities() => _context.TypeAppeal;

        public void Add(TypeAppeal entity)
        {
            if (entity is null)
                throw new ArgumentException("TypeAppeal is null");
            _context.TypeAppeal.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TypeAppeal entity)
        {
            if (entity is null)
                throw new ArgumentException("TypeAppeal is null");
            _context.TypeAppeal.Remove(entity);
            _context.SaveChanges();
        }
    }
}