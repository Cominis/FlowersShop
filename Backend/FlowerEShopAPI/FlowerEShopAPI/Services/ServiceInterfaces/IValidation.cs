﻿using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Services.ServiceInterfaces
{
    public interface IValidation
    {
        public Task<bool> ValidateShopData(string name, string location, bool isUpdate);
        public Task<bool> ValidateProductData(string shopId, string title, string category, string status, decimal price, decimal quantity, bool isUpdate);
        public Task<bool> ValidateUser(string email, string userName);
        public bool ValidateFilters(Shop shop, string status, decimal? priceStart, decimal? priceEnd);
    }
}
