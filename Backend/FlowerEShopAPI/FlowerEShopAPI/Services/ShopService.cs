using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Services.ServiceInterfaces;

namespace FlowerEShopAPI.Services
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository _shopRepository;
        private readonly IUserRepository _userRepository;
        private readonly Lazy<IValidation> _validation = null;
        public ShopService(IShopRepository shopRepository, IUserRepository userRepository, Lazy<IValidation> validation)
        {
            _shopRepository = shopRepository;
            _userRepository = userRepository;
            _validation = validation;
        }

        public async Task<Shop> CreateShop(string name, string description, string location, string userId)
        {
            var user = await _userRepository.FindOneById(userId);

            if (user != null)
            {
                await _validation.Value.ValidateShopData(name, location, false);
                var createdShop = await _shopRepository.Create(name, description, location, userId);

                return createdShop;
            }

            throw new ArgumentException("User doesn't exists");
        }

        public async Task<Shop> UpdateShop(string id, string name, string description, string location, string userId)
        {
            var shop = await _shopRepository.FindOne(id);

            if (shop.UserId.ToString() == userId.ToLower())
            {
                if (shop == null)
                {
                    throw new ArgumentException("Shop to update doesn't exist");
                }

                await _validation.Value.ValidateShopData(name, location, true);
                var updatedShop = await _shopRepository.Update(id, name, description, location);

                return updatedShop;
            }

            throw new ArgumentException("Shop to update doesn't exist");
        }

        public async Task<string> DeleteShop(string id, string userId)
        {
            var shop = await _shopRepository.FindOne(id);

            if (shop.UserId.ToString() == userId.ToLower())
            {
                if (shop != null)
                {
                    var deletedShop = await _shopRepository.Delete(id);
                    return deletedShop;
                }
                else
                {
                    throw new ArgumentException("Invalid id for deleting shop");
                }
            }
            throw new ArgumentException("User doesn't have access to delete this shop");
        }

        public async Task<Shop> GetShop(string id)
        {
            var shop = await _shopRepository.FindOne(id);

            if (shop == null)
            {
                throw new ArgumentException("Invalid id for getting shop");
            }

            return shop;
        }

    }
}
