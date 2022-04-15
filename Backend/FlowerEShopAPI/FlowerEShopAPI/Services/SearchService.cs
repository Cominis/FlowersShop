using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Services.ServiceInterfaces;

namespace FlowerEShopAPI.Services
{
    public class SearchService : ISearchService
    {
        private readonly IShopRepository _shopRepository;
        private readonly Lazy<IValidation> _validation;
        public SearchService(IShopRepository shopRepository, Lazy<IValidation> validation)
        {
            _shopRepository = shopRepository;
            _validation = validation;


        }

        public async Task<List<Shop>> SearchShops(string searchQuery, string name)
        {

            return null;
        }
    }
}
