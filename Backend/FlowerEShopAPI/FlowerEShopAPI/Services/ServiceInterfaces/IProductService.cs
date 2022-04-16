using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Services.ServiceInterfaces
{
    public interface IProductService
    {
        public Task<Product> AddProductToShop(string shopId, string title, string description, string category, string subcategory, string status, decimal price, decimal quantity, string userId);
        public Task<Product> UpdateProduct(string id, string shopId, string title, string description, string category, string subcategory, string status, decimal price, decimal quantity, string userId);
        public Task<string> DeleteProduct(string id, string userId);
        public Task<Product> GetById(string id);
        public Task<List<Product>> GetAllProducts(string shopId);
    }

}
