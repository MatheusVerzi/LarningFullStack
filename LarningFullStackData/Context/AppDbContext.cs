using LarningFullStackData.Extensions;
using LarningFullStackDomain.Entities;
using LarningFullStackInfra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace LarningFullStackInfra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.ApplyGlobalConfiguration();

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
