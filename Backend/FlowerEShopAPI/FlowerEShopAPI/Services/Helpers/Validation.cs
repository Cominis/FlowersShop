using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces;
using FlowerEShopAPI.Services.ServiceInterfaces;
using System.Text.RegularExpressions;

namespace FlowerEShopAPI.Services.Helpers
{
    public class Validation : IValidation
    {
        private readonly IShopRepository _shopRepository;
        private readonly Lazy<IHelpers> _helpers = null;

        public Validation(IShopRepository shopRepository, Lazy<IHelpers> helpers)
        {
            _shopRepository = shopRepository;
            _helpers = helpers;
        }

        public async Task<bool> ValidateShopData(string name, string location, bool isUpdate)
        {
            var nameRegex = new Regex(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$");

            var shops = await _shopRepository.FindAll();

            var isValidName = (isUpdate && _helpers.Value.IsStringEmty(name) || isUpdate && shops.Where(i => i.Name == name).Count() == 1) || (name != null && name.Length > 2 && nameRegex.IsMatch(name) && !shops.Where(i => i.Name == name).Any());
            var isValidLocation = (isUpdate && _helpers.Value.IsStringEmty(location)) || _helpers.Value.IsStringEmty(location);

            bool[] validators = { isValidName, isValidLocation };
            string[] namesOfParams = { "name", "location" };

            for (var i = 0; i < validators.Length; i++)
            {
                if (!validators[i])
                {
                    throw new ArgumentException($"Not valid {namesOfParams[i]}");
                }
            }

            return true;

        }

        public async Task<bool> ValidateProductData(string shopId, string title, string category, string status, decimal price, decimal quantity, bool isUpdate)
        {
            var nameRegex = new Regex(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$");
            var priceRegex = new Regex(@"\d+(?:\.\d+)?");
            var quantityRegex = new Regex(@"\d+");
            var statuses = new List<string> { "Available", "OutOfStock" };

            var shop = await _shopRepository.FindOne(shopId);

            var isValidShop = shop != null;
            var isValidTitle = (isUpdate && _helpers.Value.IsStringEmty(title)) || (title != null && title.Length > 2 && nameRegex.IsMatch(title));
            var isValidCategory = (isUpdate && _helpers.Value.IsStringEmty(category)) || category != null || category.Length > 1;
            var isValidStatus = (isUpdate && _helpers.Value.IsStringEmty(status)) || statuses.Contains(status);
            var isValidPrice = priceRegex.IsMatch(price.ToString()) || (isUpdate && price == null);
            var isValidQuantity = (isUpdate && quantity == null) || quantityRegex.IsMatch(quantity.ToString());

            bool[] validators = { isValidShop, isValidTitle, isValidCategory, isValidStatus, isValidPrice, isValidQuantity };
            string[] namesOfParams = { "shop", "title", "category", "status", "price", "quantity" };

            for (var i = 0; i < validators.Length; i++)
            {
                if (!validators[i])
                {
                    throw new ArgumentException($"Not valid {namesOfParams[i]}");
                }
            }

            return true;


        }
    }
}
