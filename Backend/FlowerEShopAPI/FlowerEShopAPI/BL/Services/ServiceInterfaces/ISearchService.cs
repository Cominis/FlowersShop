using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.BL.Services.ServiceInterfaces
{
    public interface ISearchService
    {
        public Task<List<Shop>> SearchShops(string searchQuery, decimal? priceStart, decimal? priceEnd, string status = "All");
    }
}
