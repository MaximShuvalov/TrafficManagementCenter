using System.Collections.Generic;
using System.Threading.Tasks;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class TypeAppealRepository : IRepository<TypeAppeal>
    {
        private TypeAppealContext _context;
        public TypeAppeal Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TypeAppeal> GetEntities()
        {
            throw new System.NotImplementedException();
        }

        public void Add(TypeAppeal entity)
        {
            if(entity is null)
                return;
            using (_context = new TypeAppealContext())
            {
                _context.TypeAppeal.Add(entity);
                _context.SaveChanges();
            }
        }
    }
}