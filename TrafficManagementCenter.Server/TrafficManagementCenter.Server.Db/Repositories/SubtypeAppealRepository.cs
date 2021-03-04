using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class SubtypeAppealRepository : IRepository<SubtypeAppeal>, IDisposable
    {
        private readonly AppDbContext _context = new AppDbContext();

        public SubtypeAppeal Get(long id) => _context.SubtypeAppeals.FirstOrDefault(o => o.Key.Equals(id));

        public IEnumerable<SubtypeAppeal> GetEntities() => _context.SubtypeAppeals;

        public void Add(SubtypeAppeal entity)
        {
            if (entity is null)
                throw new ArgumentException("SubtypeAppeal is null");
            _context.SubtypeAppeals.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(SubtypeAppeal entity)
        {
            if (entity is null)
                throw new ArgumentException("SubtypeAppeal is null");
            _context.SubtypeAppeals.Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}