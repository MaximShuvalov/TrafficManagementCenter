using Microsoft.EntityFrameworkCore;
using Model;

namespace TrafficManagementCenter.Server.Db.Context
{
    public class AppealContext : DbContext
    {
        public AppealContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5433; Database=TrafficManagementCenter; Username=TestUser; Password=Qwerty123;");
        }
        
        public DbSet<Appeal> TypeAppeal { get; set; }
    }
}