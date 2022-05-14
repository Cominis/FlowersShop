using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces;

namespace FlowerEShopAPI.BL.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUserRepository _userRepository;
        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository, IUserRepository userRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _productRepository = productRepository;
            _userRepository = userRepository;
        }

        public async Task<ShoppingCart> AddToCart(string productId, int quantity, string userId)
        {
            var product = await _productRepository.FindOne(productId);
            var user = await _userRepository.FindOneById(userId);

            if (user != null)
            {
                if (product == null)
                {
                    throw new ArgumentException("Product doesn't exists");
                }

                var shoppingCart = await _shoppingCartRepository.Add(productId, quantity, userId);

                return shoppingCart;
            }

            throw new ArgumentException("User doesn't exists");
        }

        public async Task<List<ShoppingCart>> GetShoppingCart(string userId)
        {
            var user = await _userRepository.FindOneById(userId);

            if (user == null)
            {
                throw new ArgumentException("User doesn't exists");
            }

            var shoppingCart = await _shoppingCartRepository.FindAll(userId);

            return shoppingCart;
        }

        public async Task<string> RemoveFromCart(string id, string userId)
        {
            var shoppingCart = await _shoppingCartRepository.FindOne(id);

            if (shoppingCart.UserId.ToString() == userId)
            {
                if (shoppingCart != null)
                {
                    var deletedShoppingCart = await _shoppingCartRepository.Delete(id);

                    return deletedShoppingCart;
                }
                else
                {
                    throw new ArgumentException("Invalid id for deleting shoppingCart");
                }
            }
            throw new ArgumentException("User doesn't have access to delete this shop");
        }
    }
}
