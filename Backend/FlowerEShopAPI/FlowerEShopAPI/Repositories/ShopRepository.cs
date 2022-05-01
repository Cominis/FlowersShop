using FlowerEShopAPI.DAL;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces;
using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly FlowerShopDBContext _context;
        private readonly Lazy<IHelpers> _helpers = null;
        public ShopRepository(FlowerShopDBContext context, Lazy<IHelpers> helpers)
        {
            _context = context;
            _helpers = helpers;
        }

        public async Task<Shop?> Create(string name, string description, string location, string userId)
        {
            var shop = new Shop { Name = name, Description = description, Location = location, UserId = Guid.Parse(userId) };

            _context.Shops.Add(shop);
            await _context.SaveChangesAsync();

            var shopDetails = await FindOne(shop.Id.ToString());

            return shopDetails;
        }
        public async Task<Shop?> Update(string id, string name, string description, string location)
        {
            var shop = _context.Shops.SingleOrDefault(b => b.Id.ToString() == id);

            shop.Name = _helpers.Value.IsStringEmty(name) ? shop.Name : name;
            shop.Description = _helpers.Value.IsStringEmty(description) ? shop.Description : description;
            shop.Location = _helpers.Value.IsStringEmty(location) ? shop.Location : location;
            shop.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            var updatedShop = _context.Shops.SingleOrDefault(b => b.Id.ToString() == id);

            return updatedShop;
        }

        public async Task<string> Delete(string id)
        {
            var shop = _context.Shops.SingleOrDefault(b => b.Id.ToString() == id);

            _context.Shops.Remove(shop);

            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<List<Shop>?> FindAll()
        {
            var shops = await _context.Shops.Include(b => b.Products).ToListAsync();

            return shops.ToList();
        }

        public async Task<Shop?> FindOne(string id)
        {
            var shop = await _context.Shops.Include(b => b.Products).SingleOrDefaultAsync(b => b.Id.ToString() == id);

            return shop;
        }
    }
}
