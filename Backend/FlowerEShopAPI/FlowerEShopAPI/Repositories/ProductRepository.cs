using FlowerEShopAPI.DAL;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces;
using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly FlowerShopDBContext _context;
        private readonly Lazy<IEnumConverter> _enumConverter = null;
        private readonly Lazy<IHelpers> _helpers = null;

        public ProductRepository(FlowerShopDBContext context, Lazy<IEnumConverter> enumConverter, Lazy<IHelpers> helpers)
        {
            _context = context;
            _enumConverter = enumConverter;
            _helpers = helpers;
        }

        public async Task<Product?> Create(string shopId, string title, string description, string category, string location, string status, decimal price, decimal quantity, string subCategory = "")
        {
            var createdAt = DateTime.UtcNow;
            var updatedAt = DateTime.UtcNow;

            var product = new Product(Guid.Parse(shopId), title, description, category, location, _enumConverter.Value.StringToStatusEnum(status), price, quantity, createdAt, updatedAt, subCategory);

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product?> Update(string id, string shopId, string title, string description, string category, string location, string status, decimal? price, decimal? quantity, string subCategory = "")
        {
            var updatedAt = DateTime.UtcNow;
            var product = _context.Products.SingleOrDefault(p => p.Id.ToString() == id && p.ShopId.ToString() == shopId);

            product.Title = _helpers.Value.IsStringEmty(title) ? product.Title : title;
            product.Description = _helpers.Value.IsStringEmty(description) ? product.Description : description;
            product.Category = _helpers.Value.IsStringEmty(category) ? product.Category : category;
            product.Location = _helpers.Value.IsStringEmty(location) ? product.Location : location;
            product.Status = _helpers.Value.IsStringEmty(status) ? product.Status : _enumConverter.Value.StringToStatusEnum(status);
            product.Price = (decimal)(price != null ? price : product.Price);
            product.Quantity = (decimal)(quantity != null ? quantity : product.Quantity);
            product.SubCategory = _helpers.Value.IsStringEmty(subCategory) ? product.SubCategory : subCategory;
            product.UpdatedAt = updatedAt;

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<string> Delete(string id)
        {
            var product = _context.Products.SingleOrDefault(b => b.Id.ToString() == id);
            var dateNow = DateTime.UtcNow;

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<List<Product>> FindAll(string shopId)
        {
            var products = await _context.Products.Where(a => a.ShopId.ToString() == shopId).ToListAsync();

            return products;
        }

        public async Task<Product> FindOne(string id)
        {
            var product = await _context.Products.SingleOrDefaultAsync(b => b.Id.ToString() == id);

            return product;
        }
    }
}
