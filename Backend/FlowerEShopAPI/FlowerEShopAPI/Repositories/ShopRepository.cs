using FlowerEShopAPI.DAL;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly FlowerShopDBContext _context;
        private readonly IProductRepository _productRepository;
        public ShopRepository(FlowerShopDBContext context, IProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }

        public async Task<Shop?> Create(string name, string description, string userId)
        {
            var createdAt = DateTime.UtcNow;
            var updatedAt = DateTime.UtcNow;
            var shopId = Guid.NewGuid().ToString();

            var shop = new Shop(shopId, name, description, createdAt, updatedAt, userId);

            _context.Shops.Add(shop);
            await _context.SaveChangesAsync();

            var shopDetails = await FindOne(shop.Id);

            return shopDetails != null ? CheckForProducts(shopDetails) : shopDetails;
        }
        public async Task<Shop?> Update(string id, string name, string description, Product[] products)
        {
            var updatedAt = DateTime.UtcNow;
            var shop = _context.Shops.SingleOrDefault(b => b.Id == id);

            shop.Name = IsStringEmty(name) ? shop.Name : name;
            shop.Description = IsStringEmty(description) ? shop.Description : description;
            shop.UpdatedAt = updatedAt;

            var previousShopProducts = await _productRepository.FindAll(id);
            var deletedShopProducts = previousShopProducts.Where(a => products.Where(b => a.Id == b.Id).Count() == 0).ToList();
            var addedShopProducts = products.Where(a => a.Id == null).ToList();

            foreach (var product in deletedShopProducts)
            {
                await _productRepository.Delete(product.Id);
            }

            foreach (var product in addedShopProducts)
            {
                await _productRepository.Create(product.Id, product.Title, product.Description, product.Category, product.Location, product.Status.ToString(), product.Price, product.Quantity, product.SubCategory);
            }


            await _context.SaveChangesAsync();

            var updatedShop = _context.Shops.SingleOrDefault(b => b.Id == id);

            return updatedShop != null ? CheckForProducts(updatedShop) : updatedShop;
        }

        public async Task<string> Delete(string id)
        {
            var shop = _context.Shops.SingleOrDefault(b => b.Id == id);

            _context.Shops.Remove(shop);

            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<List<Shop>?> FindAll()
        {
            var shops = await _context.Shops.Include(b => b.Product).ToListAsync();

            return shops.Select(shop => CheckForProducts(shop)).ToList();
        }

        public async Task<Shop?> FindOne(string id)
        {
            var shop = await _context.Shops.Include(b => b.Product).SingleOrDefaultAsync(b => b.Id == id);

            return shop != null ? CheckForProducts(shop) : shop;
        }

        private static bool IsStringEmty(string str)
        {
            if (str == null || str.Length == 0)
            {
                return true;
            }
            return false;
        }

        private static Shop CheckForProducts(Shop shop)
        {
            if (shop.Product == null)
            {
                shop.Product = new List<Product>();
            }

            return shop;
        }

    }
}
