using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces;

namespace FlowerEShopAPI.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IShopRepository _shopRepository;
        private readonly Lazy<IValidation> _validation = null;
        public ProductService(IProductRepository productRepository, IShopRepository shopRepository, Lazy<IValidation> validation)
        {
            _productRepository = productRepository;
            _shopRepository = shopRepository;
            _validation = validation;
        }

        public async Task<Product> AddProductToShop(string shopId, string title, string description, string category, string subcategory, string status, decimal price, decimal quantity, string userId)
        {
            var shop = await _shopRepository.FindOne(shopId);

            if (shop.Id.ToString() == shopId)
            {
                await _validation.Value.ValidateProductData(shopId, title, category, status, price, quantity, false);
                var createdProduct = await _productRepository.Create(shopId, title, description, category, status, price, quantity, subcategory);
                return createdProduct;
            }

            throw new ArgumentException("User cannot add products to this shop");

        }
        public async Task<Product> UpdateProduct(string id, string shopId, string title, string description, string category, string subcategory, string status, decimal price, decimal quantity, string userId)
        {
            var shop = await _shopRepository.FindOne(shopId);

            if (shop.UserId.ToString() == userId)
            {
                var product = await _productRepository.FindOne(id);

                if (product == null)
                {
                    throw new ArgumentException("Product to update doesn't exist");
                }

                await _validation.Value.ValidateProductData(shopId, title, category, status, price, quantity, true);
                var updatedProduct = await _productRepository.Update(id, shopId, title, description, category, status, price, quantity, subcategory);
                return updatedProduct;
            }
            throw new ArgumentException("User cannot add products to this shop");
        }

        public async Task<string> DeleteProduct(string id, string userId)
        {
            var products = await _productRepository.FindOne(id);
            var shop = await _shopRepository.FindOne(products.ShopId.ToString());

            if (shop.UserId.ToString() == userId)
            {

                if (products != null)
                {
                    var deletedProduct = await _productRepository.Delete(id);
                    return deletedProduct;
                }
                else
                {
                    throw new ArgumentException("Invalid products parameters for deleting");
                }

            }

            throw new ArgumentException("User cannot delete products of this shop");
        }
        public async Task<Product> GetById(string id)
        {
            var product = await _productRepository.FindOne(id);

            if (product == null)
            {
                throw new ArgumentException("Product doesn't exist");
            }
            return product;
        }
        public async Task<List<Product>> GetAllProducts(string shopId)
        {
            var shop = await _shopRepository.FindOne(shopId);

            if (shop == null)
            {
                throw new ArgumentException("Couldn't get products of shop which doesn't exist");
            }

            var products = await _productRepository.FindAll(shopId);
            return products;
        }
    }
}
