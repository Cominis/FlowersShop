using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Services.ServiceInterfaces
{
    public interface ISearchService
    {
        public Task<List<Shop>> SearchShops(string searchQuery);
    }
}
