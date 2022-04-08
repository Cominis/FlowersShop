using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace FlowerEShopAPI.DAL.Entities
{
    public class ShoppingCartContext : DbContext
    {
        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options)
           : base(options)
        {
        }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; } = null!;
    }
}
