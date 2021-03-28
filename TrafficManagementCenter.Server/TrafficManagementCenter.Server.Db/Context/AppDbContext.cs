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
            //Database.Migrate();
        }

        public AppDbContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //todo mshuvalov: забирать из конфига
            optionsBuilder.UseNpgsql(
                "Server=127.0.0.1;Port=5433; Database=team1; Username=t1; Password=admin;");
        }

        public DbSet<Appeal> Appeal { get; set; }
        public DbSet<SubtypeAppeal> SubtypeAppeals { get; set; }
        public DbSet<TypeAppeal> TypeAppeal { get; set; }
        public DbSet<AppealClass> ClassAppeal { get; set; }
    }
}