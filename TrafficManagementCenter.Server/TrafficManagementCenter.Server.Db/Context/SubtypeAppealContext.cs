using Microsoft.EntityFrameworkCore;
using Model;

namespace TrafficManagementCenter.Server.Db.Context
{
    public class SubtypeAppealContext : DbContext
    {
        public SubtypeAppealContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5433; Database=TrafficManagementCenter; Username=TestUser; Password=Qwerty123;");
        }
        
        public DbSet<SubtypeAppeal> SubtypesAppeals { get; set; }
        
    }
}