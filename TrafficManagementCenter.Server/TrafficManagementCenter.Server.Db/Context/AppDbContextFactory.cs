using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TrafficManagementCenter.Server.Db.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseNpgsql("Host=localhost; Port=5432; Database=TrafficManagementCenter; Username=TestUser; Password=Qwerty123;");
            return new AppDbContext(builder.Options);
        }
    }
}