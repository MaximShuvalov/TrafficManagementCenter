using System.Linq;
using TrafficManagementCenter.Server.Db.Repositories;

namespace TrafficManagementCenter.Server.Db.Extensions
{
    public static class AppealRepositoryExtensions
    {
        public static long GetIdByEmailAndText(this AppealRepository repos, string email, string text)
        {
            return repos.GetEntities().FirstOrDefault(p 
                => p.Email.Equals(email) && p.Text.Equals(text)).Key;
        }
    }
}