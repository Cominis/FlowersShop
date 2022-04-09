using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.DAL.Entities
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
