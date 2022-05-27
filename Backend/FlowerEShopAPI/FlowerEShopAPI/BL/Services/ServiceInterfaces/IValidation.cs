using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.BL.Services.ServiceInterfaces
{
    public interface IValidation
    {
        public Task<bool> ValidateShopData(string name, string location, bool isUpdate);
        public Task<bool> ValidateProductData(string shopId, string title, string category, string status, decimal price, decimal quantity, bool isUpdate);
        public Task<bool> ValidateUser(string email, string userName, string password, bool isUpdate);
        public bool ValidateFilters(Shop shop, string status, decimal? priceStart, decimal? priceEnd);
        List<Product> ValidateSorting(List<Product> products, string item);
    }
}
