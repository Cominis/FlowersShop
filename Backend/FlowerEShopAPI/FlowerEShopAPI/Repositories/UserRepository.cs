using FlowerEShopAPI.DAL;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FlowerShopDBContext _context;
        public UserRepository(FlowerShopDBContext context)
        {
            _context = context;
        }

        public async Task<User> Create(string name, string surname, string userName, string password)
        {
            var user = new User(name, surname, userName, password);

            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> FindOne(string userName)
        {
            var user = await _context.User.SingleOrDefaultAsync(u => u.UserName == userName);

            return user;
        }

        public async Task<User> FindOneById(string id)
        {
            var user = await _context.User.SingleOrDefaultAsync(u => u.Id.ToString() == id);

            return user;
        }

        public async Task<string> Delete(string id)
        {
            var user = _context.User.SingleOrDefault(u => u.Id.ToString() == id);

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return id;
        }
    }
}
