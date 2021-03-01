﻿using Microsoft.EntityFrameworkCore;
using Model;

namespace TrafficManagementCenter.Server.Db.Context
{
    public class TypeAppealContext : DbContext
    {
        public TypeAppealContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5433; Database=TrafficManagementCenter; Username=TestUser; Password=Qwerty123;");
        }
        
        public DbSet<TypeAppeal> TypeAppeal { get; set; }
    }
}