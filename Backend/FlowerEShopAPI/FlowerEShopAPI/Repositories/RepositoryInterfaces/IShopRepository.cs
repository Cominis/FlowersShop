using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Repositories.RepositoryInterfaces
{
    public interface IShopRepository
    {
        public Task<Shop?> Create(string name, string description, string location, string userId);
        public Task<Shop?> Update(string id, string name, string description, string location);
        public Task<string> Delete(string id);
        public Task<Shop?> FindOne(string id);
        public Task<List<Shop>?> FindAll();
    }
}
