using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Services.ServiceInterfaces
{
    public interface IShopService
    {
        public Task<Shop> CreateShop(string name, string description, string location, string userId);
        public Task<Shop> UpdateShop(string id, string name, string description, string location, string userId);
        public Task<string> DeleteShop(string id, string userId);
        public Task<Shop> GetShop(string id);
    }
}
