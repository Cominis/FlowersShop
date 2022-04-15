using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Services.ServiceInterfaces
{
    public interface IUserService
    {
        public Task<User> GetUserById(string id);
        public Task<User> GetUserByUserName(string userName);
        public Task<User> CreateUser(string name, string surname, string username, string password);
    }
}
