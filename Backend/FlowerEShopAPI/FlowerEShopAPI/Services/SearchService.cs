using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Services.ServiceInterfaces;
using System.Text.RegularExpressions;

namespace FlowerEShopAPI.Services
{
    public class SearchService : ISearchService
    {
        private readonly IShopRepository _shopRepository;
        public SearchService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public async Task<List<Shop>> SearchShops(string searchQuery)
        {
            var trimmedSearchQuery = searchQuery.Trim();
            var regex = new Regex(@"^(?=.*\b" + trimmedSearchQuery + @"\b).*$");

            var shopList = await _shopRepository.FindAll();


            return searchQuery.Length > 0 ? shopList.Where(shop => regex.IsMatch(shop.Name) || regex.IsMatch(shop.Location)).ToList() : shopList.ToList();
        }
    }
}
