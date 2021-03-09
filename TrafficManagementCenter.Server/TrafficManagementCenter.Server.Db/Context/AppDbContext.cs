using Microsoft.EntityFrameworkCore;
using Model;

namespace TrafficManagementCenter.Server.Db.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        public AppDbContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost; Port=5433; Database=TrafficManagementCenter; Username=TestUser; Password=Qwerty123;");
        }

        public DbSet<Appeal> Appeal { get; set; }
        public DbSet<SubtypeAppeal> SubtypeAppeals { get; set; }
        public DbSet<TypeAppeal> TypeAppeal { get; set; }
    }
}