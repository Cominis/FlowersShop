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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow;

                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasAlternateKey(table => new
            {
                table.UserName,
                table.Password
            });

            modelBuilder.Entity<Shop>()
            .HasOne(b => b.User)
            .WithOne(c => c.Shop).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Shop>()
            .HasMany(b => b.Products)
            .WithOne(c => c.Shop);

            modelBuilder.Entity<ShoppingCart>()
            .HasOne(b => b.Product)
            .WithMany(c => c.ShoppingCarts).OnDelete(DeleteBehavior.NoAction); ;

            modelBuilder.Entity<ShoppingCart>()
            .HasOne(b => b.User)
            .WithMany(c => c.ShoppingCarts).OnDelete(DeleteBehavior.NoAction); ;
        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<User> User { get; set; }
    }
}

