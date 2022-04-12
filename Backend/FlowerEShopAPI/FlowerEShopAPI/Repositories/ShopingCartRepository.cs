using FlowerEShopAPI.DAL;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.Repositories
{
    public class ShopingCartRepository : IShoppingCartRepository
    {
        private readonly FlowerShopDBContext _context;

        public ShopingCartRepository(FlowerShopDBContext context)
        {
            _context = context;
        }

        public async Task<ShoppingCart> Add(string productId, string userId)
        {
            var shoppingCart = new ShoppingCart { ProductId = Guid.Parse(productId), UserId = Guid.Parse(userId) };

            _context.ShoppingCart.Add(shoppingCart);
            await _context.SaveChangesAsync();

            return shoppingCart;
        }

        public async Task<string> Delete(string id)
        {
            var shoppingCart = _context.ShoppingCart.SingleOrDefault(b => b.Id.ToString() == id);

            _context.ShoppingCart.Remove(shoppingCart);
            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<List<ShoppingCart>> FindAll(string userId)
        {
            var shoppingCarts = await _context.ShoppingCart.Where(a => a.UserId.ToString() == userId).ToListAsync();

            return shoppingCarts;
        }

        public async Task<ShoppingCart> FindById(string id)
        {
            var shoppingCart = await _context.ShoppingCart.SingleOrDefaultAsync(b => b.Id.ToString() == id);

            return shoppingCart;
        }
    }
}
