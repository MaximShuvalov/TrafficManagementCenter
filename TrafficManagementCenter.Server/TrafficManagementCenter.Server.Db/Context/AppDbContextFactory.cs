using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TrafficManagementCenter.Server.Db.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=TrafficManagementCenter;Username=TestUser;Password=Qwerty123; Timeout=300; CommandTimeout=300");
            return new AppDbContext(builder.Options);
        }
    }
}