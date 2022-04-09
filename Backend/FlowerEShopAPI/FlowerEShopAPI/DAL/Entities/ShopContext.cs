using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.DAL.Entities
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
           : base(options)
        {
        }

        public DbSet<Shop> Shops { get; set; } = null!;
    }
}
