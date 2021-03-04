using Microsoft.Extensions.DependencyInjection;
using Model;
using TrafficManagementCenter.Server.Db.Repositories;

namespace TrafficManagementCenter.Server.Db.DI
{
    public static class DipendencyInjection
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Appeal>, AppealRepository>();
            services.AddScoped<IRepository<TypeAppeal>, TypeAppealRepository>();
            services.AddScoped<IRepository<SubtypeAppeal>, SubtypeAppealRepository>();
        }
    }
}