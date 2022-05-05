using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces
{
    public interface IUserRepository
    {
        public Task<User> Create(string name, string email, string surname, string userName, string password);
        public Task<User> Update(string id, string name, string email, string surname, string userName, string password);
        public Task<User> FindByUsername(string userName);
        public Task<User> FindOneById(string id);
        public Task<string> Delete(string id);
    }
}
