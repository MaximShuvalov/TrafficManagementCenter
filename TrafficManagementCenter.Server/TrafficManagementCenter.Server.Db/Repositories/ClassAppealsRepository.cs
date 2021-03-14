using System.Collections.Generic;
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
            throw new System.NotImplementedException();
        }

        public void Delete(ClassAppeal entity)
        {
            throw new System.NotImplementedException();
        }
    }
}