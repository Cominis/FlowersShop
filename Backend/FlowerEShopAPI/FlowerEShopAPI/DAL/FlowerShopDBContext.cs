using FlowerEShopAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.DAL
{
    public class FlowerShopDBContext : DbContext
    {
        public FlowerShopDBContext(DbContextOptions<FlowerShopDBContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(table => new
            {
                table.Id,
                table.UserName,
                table.Password
            });

            modelBuilder.Entity<Shop>()
            .HasOne(b => b.User)
            .WithOne(i => i.Shop)
            .HasPrincipalKey<User>(b => b.Id);
        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<User> User { get; set; }
    }
}

