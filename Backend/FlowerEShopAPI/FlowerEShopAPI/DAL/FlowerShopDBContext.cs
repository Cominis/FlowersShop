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

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<User> User { get; set; }



    }
}
