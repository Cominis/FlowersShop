using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces;
using System.Text.RegularExpressions;

namespace FlowerEShopAPI.BL.Services
{
    public class SearchService : ISearchService
    {
        private readonly IShopRepository _shopRepository;
        private readonly IValidation _validation;
        public SearchService(IShopRepository shopRepository, IValidation validation)
        {
            _shopRepository = shopRepository;
            _validation = validation;
        }

        public async Task<List<Shop>> SearchShops(string searchQuery, decimal? priceStart, decimal? priceEnd, string status = "All")
        {
            var checkedSearchQuery = searchQuery == "All" ? "" : searchQuery;
            var trimmedSearchQuery = checkedSearchQuery.Trim();
            var regex = new Regex(@"^(?=.*\b" + trimmedSearchQuery + @"\b).*$");

            var shopList = (await _shopRepository.FindAll()).Where(shop => _validation.ValidateFilters(shop, status, priceStart, priceEnd));

            return searchQuery.Length > 0 ?
                shopList.Any(shop => regex.IsMatch(shop.Name) || regex.IsMatch(shop.Location)) ? shopList.Where(shop => regex.IsMatch(shop.Name) || regex.IsMatch(shop.Location)).ToList() :
                shopList.Any(shop => shop.Products.Any(product => regex.IsMatch(product.Title)) || shop.Products.Any(product => regex.IsMatch(product.Category)) || shop.Products.Any(product => regex.IsMatch(product.SubCategory))) ?
                shopList.Where((shop => shop.Products.Any(product => regex.IsMatch(product.Title)) || shop.Products.Any(product => regex.IsMatch(product.Category)) || shop.Products.Any(product => regex.IsMatch(product.SubCategory)))).ToList() :
                shopList.ToList() :
                new List<Shop>();
        }
    }
}
