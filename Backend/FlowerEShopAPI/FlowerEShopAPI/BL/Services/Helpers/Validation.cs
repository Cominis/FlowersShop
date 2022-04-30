using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces.HelpersInterfaces;
using System.Text.RegularExpressions;

namespace FlowerEShopAPI.BL.Services.Helpers
{
    public class Validation : IValidation
    {
        private readonly IShopRepository _shopRepository;
        private readonly IUserRepository _userRepository;
        private readonly Lazy<IHelpers> _helpers = null;
        private readonly Lazy<IEnumConverter> _enumConverter = null;

        public Validation(IShopRepository shopRepository, IUserRepository userRepository, Lazy<IHelpers> helpers, Lazy<IEnumConverter> enumConverter)
        {
            _shopRepository = shopRepository;
            _userRepository = userRepository;
            _helpers = helpers;
            _enumConverter = enumConverter;
        }

        public async Task<bool> ValidateShopData(string name, string location, bool isUpdate)
        {
            var nameRegex = new Regex(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$");

            var shops = await _shopRepository.FindAll();

            var isValidName = (isUpdate && _helpers.Value.IsStringEmty(name) || isUpdate && shops.Where(i => i.Name == name).Count() == 1) || (name != null && name.Length > 2 && nameRegex.IsMatch(name) && !shops.Where(i => i.Name == name).Any());
            var isValidLocation = (isUpdate && _helpers.Value.IsStringEmty(location) || isUpdate && shops.Where(i => i.Location == location).Count() == 1) || !_helpers.Value.IsStringEmty(location);

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

        public async Task<bool> ValidateProductData(string userId, string title, string category, string status, decimal price, decimal quantity, bool isUpdate)
        {
            var nameRegex = new Regex(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$");
            var priceRegex = new Regex(@"\d+(?:\.\d+)?");
            var quantityRegex = new Regex(@"\d+");
            var statuses = new List<string> { "Available", "OutOfStock" };

            var shop = await _shopRepository.FindOne(userId);

            var isValidShop = shop != null;
            var isValidTitle = (isUpdate && _helpers.Value.IsStringEmty(title) || isUpdate && shop.Products.Where(product => product.Title == title).Count() == 1) || (title != null && title.Length > 2 && nameRegex.IsMatch(title));
            var isValidCategory = (isUpdate && _helpers.Value.IsStringEmty(category) || isUpdate && shop.Products.Where(product => product.Category == category).Count() == 1) || category != null && category.Length > 1;
            var isValidStatus = (isUpdate && _helpers.Value.IsStringEmty(status)) || statuses.Contains(status);
            var isValidPrice = priceRegex.IsMatch(price.ToString()) || (isUpdate && price > 0 || isUpdate && shop.Products.Where(product => product.Price == price).Count() == 1);
            var isValidQuantity = (isUpdate && quantity > 0 || isUpdate && shop.Products.Where(product => product.Quantity == quantity).Count() == 1) || quantityRegex.IsMatch(quantity.ToString());

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

        public async Task<bool> ValidateUser(string email, string userName, string password, bool isUpdate)
        {
            var emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            var passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
            var usersWithuserName = await _userRepository.FindByUsername(userName);
            var userWithEmail = await _userRepository.FindByEmail(email);

            var isValidUserName = (isUpdate && _helpers.Value.IsStringEmty(userName)) || !_helpers.Value.IsStringEmty(userName) && usersWithuserName == null;
            var isValidEmail = !_helpers.Value.IsStringEmty(email) && emailRegex.IsMatch(email) && userWithEmail == null;
            var isValidPassword = passwordRegex.IsMatch(password);

            bool[] validators = { isValidUserName, isValidEmail };
            string[] namesOfParams = { "userName", "email" };

            for (var i = 0; i < validators.Length; i++)
            {
                if (!validators[i])
                {
                    throw new ArgumentException($"Not valid {namesOfParams[i]}");
                }
            }

            if (!isValidPassword)
            {
                throw new ArgumentException("Password must have minimum eight characters, at least one uppercase letter, one lowercase letter and one number");
            }

            return true;
        }

        public bool ValidateFilters(Shop shop, string status, decimal? priceStart, decimal? priceEnd)
        {
            return (status != "All" && priceStart > 0 && priceEnd > 0 && shop.Products.Any(product => product.Status == _enumConverter.Value.StringToStatusEnum(status)) && shop.Products.Any(product => product.Price >= priceStart) && shop.Products.Any(product => product.Price <= priceEnd))
                || (status != "All" && priceStart == 0 && priceEnd > 0 && shop.Products.Any(product => product.Status == _enumConverter.Value.StringToStatusEnum(status)) && shop.Products.Any(product => product.Price <= priceEnd))
                || (status != "All" && priceStart > 0 && priceEnd == 0 && shop.Products.Any(product => product.Status == _enumConverter.Value.StringToStatusEnum(status)) && shop.Products.Any(product => product.Price >= priceStart))
                || (status != "All" && priceStart == 0 && priceEnd == 0 && shop.Products.Any(product => product.Status == _enumConverter.Value.StringToStatusEnum(status)))
                || (status == "All" && priceStart == 0 && priceEnd > 0 && shop.Products.Any(product => product.Price <= priceEnd))
                || (status == "All" && priceStart > 0 && priceEnd == 0 && shop.Products.Any(product => product.Price >= priceStart))
                || (status == "All" && priceStart > 0 && priceEnd > 0 && shop.Products.Any(product => product.Price >= priceStart) && shop.Products.Any(product => product.Price <= priceEnd))
                || (status == "All" && priceStart == 0 && priceEnd == 0);
        }

        public List<Product> ValidateSorting(List<Product> products, string item)
        {
            return item switch
            {
                "category" => products.OrderByDescending(product => product.Category).ToList(),
                "title" => products.OrderByDescending(product => product.Title).ToList(),
                _ => products,
            };
        }
    }
}
