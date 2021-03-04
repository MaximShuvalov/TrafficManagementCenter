using System.Linq;
using System.Threading.Tasks;
using Model;
using TrafficManagementCenter.Server.Db.Repositories;

namespace TrafficManagementCenter.Server.Db.Extensions
{
    public static class DbExtensions
    {
        public static long GetAppealKey(this Appeal appeal)
        {
            var repos = new AppealRepository();
            var appeals = repos.GetEntities().Result;
            return appeals.FirstOrDefault(o => o.Text != null && o.Email.Equals(appeal.Email) 
                                                              && o.Text.Equals(appeal.Text)).Key;
        }
    }
}