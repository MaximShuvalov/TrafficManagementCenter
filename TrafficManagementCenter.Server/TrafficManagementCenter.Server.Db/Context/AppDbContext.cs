using Microsoft.EntityFrameworkCore;
using Model;

namespace TrafficManagementCenter.Server.Db.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; Database=TrafficManagementCenter; Username=TestUser; Password=Qwerty123;");
        }
        
        public DbSet<Appeal> Appeal { get; set; }
        public DbSet<SubtypeAppeal> SubtypeAppeals { get; set; }
        public DbSet<TypeAppeal> TypeAppeal { get; set; }
    }
}