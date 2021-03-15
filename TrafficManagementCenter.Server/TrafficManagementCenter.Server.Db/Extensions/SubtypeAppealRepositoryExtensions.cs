using System.Collections.Generic;
using System.Linq;
using Model;
using TrafficManagementCenter.Server.Db.Context;
using TrafficManagementCenter.Server.Db.Repositories;

namespace TrafficManagementCenter.Server.Db.Extensions
{
    public static class SubtypeAppealRepositoryExtensions
    {
        public static IEnumerable<SubtypeAppeal> GetSubtypeByTypeAppeal(this SubtypeAppealRepository repos,
            string nameTypeAppeal)
        {
            var keyType = new TypeAppealRepository(new AppDbContext()).GetEntities()
                .FirstOrDefault(p => p.Name.Equals(nameTypeAppeal)).Key;
            return repos.GetEntities().Where(l => l.TypesId.Equals(keyType));
        }  
    }
}