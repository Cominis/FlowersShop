﻿using FlowerEShopAPI.DAL;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces;
using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly FlowerShopDBContext _context;
        private readonly IProductRepository _productRepository;
        private readonly Lazy<IHelpers> _helpers = null;
        public ShopRepository(FlowerShopDBContext context, IProductRepository productRepository, Lazy<IHelpers> helpers)
        {
            _context = context;
            _productRepository = productRepository;
            _helpers = helpers;
        }

        public async Task<Shop?> Create(string name, string description, string userId)
        {
            var createdAt = DateTime.UtcNow;
            var updatedAt = DateTime.UtcNow;

            var shop = new Shop(name, description, createdAt, updatedAt, Guid.Parse(userId));

            _context.Shops.Add(shop);
            await _context.SaveChangesAsync();

            var shopDetails = await FindOne(shop.Id.ToString());

            return shopDetails != null ? CheckForProducts(shopDetails) : shopDetails;
        }
        public async Task<Shop?> Update(string id, string name, string description, Product[] products)
        {
            var updatedAt = DateTime.UtcNow;
            var shop = _context.Shops.SingleOrDefault(b => b.Id.ToString() == id);

            shop.Name = _helpers.Value.IsStringEmty(name) ? shop.Name : name;
            shop.Description = _helpers.Value.IsStringEmty(description) ? shop.Description : description;
            shop.UpdatedAt = updatedAt;

            var previousShopProducts = await _productRepository.FindAll(id);
            var deletedShopProducts = previousShopProducts.Where(a => products.Where(b => a.Id == b.Id).Count() == 0).ToList();
            var addedShopProducts = products.Where(a => a.Id.ToString() == null).ToList();

            foreach (var product in deletedShopProducts)
            {
                await _productRepository.Delete(product.Id.ToString());
            }

            foreach (var product in addedShopProducts)
            {
                await _productRepository.Create(product.ShopId.ToString(), product.Title, product.Description, product.Category, product.Location, product.Status.ToString(), product.Price, product.Quantity, product.SubCategory);
            }


            await _context.SaveChangesAsync();

            var updatedShop = _context.Shops.SingleOrDefault(b => b.Id.ToString() == id);

            return updatedShop != null ? CheckForProducts(updatedShop) : updatedShop;
        }

        public async Task<string> Delete(string id)
        {
            var shop = _context.Shops.SingleOrDefault(b => b.Id.ToString() == id);

            _context.Shops.Remove(shop);

            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<List<Shop>?> FindAll()
        {
            var shops = await _context.Shops.Include(b => b.Product).ToListAsync();

            return shops.Select(shop => CheckForProducts(shop)).ToList();
        }

        public async Task<Shop?> FindOne(string id)
        {
            var shop = await _context.Shops.Include(b => b.Product).SingleOrDefaultAsync(b => b.Id.ToString() == id);

            return shop != null ? CheckForProducts(shop) : shop;
        }

        private static Shop CheckForProducts(Shop shop)
        {
            if (shop.Product == null)
            {
                shop.Product = new List<Product>();
            }

            return shop;
        }

    }
}