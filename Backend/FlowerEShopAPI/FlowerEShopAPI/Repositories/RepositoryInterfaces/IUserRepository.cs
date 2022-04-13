using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Repositories.RepositoryInterfaces
{
    public interface IUserRepository
    {
        public Task<User> Create(string name, string surname, string userName, string password);
        public Task<User> FindOne(string userName);
        public Task<User> FindOneById(string id);
        public Task<string> Delete(string id);
    }
}
