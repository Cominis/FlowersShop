using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.BL.Services.ServiceInterfaces
{
    public interface IUserService
    {
        public Task<User> GetUserById(string id);
        public Task<User> GetUserByUserName(string userName);
        public Task<User> UpdateUser(string id, string name, string email, string surname, string userName, string password);
        public Task<User> CreateUser(string name, string email, string surname, string username, string password);
    }
}
