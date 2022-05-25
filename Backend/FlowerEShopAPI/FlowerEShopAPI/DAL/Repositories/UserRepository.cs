using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace FlowerEShopAPI.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FlowerShopDBContext _context;
        public UserRepository(FlowerShopDBContext context)
        {
            _context = context;
        }

        public async Task<User> Create(string name, string email, string surname, string userName, string password)
        {
            var hashPassword = BCrypt.Net.BCrypt.HashPassword(password);
            var user = new User { Name = name, Email = email, Surname = surname, UserName = userName, Password = hashPassword };

            _context.User.Add(user);

            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> Update(string id, string name, string email, string surname, string userName, string password)
        {
            var user = await _context.User.SingleOrDefaultAsync(u => u.Id.ToString() == id);

            user.Name = name;
            user.Surname = surname;
            user.UserName = userName;
            user.Email = email;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbUpdateConcurrencyException("Already modified. Try again");
            }
            return user;
        }

        public async Task<User> FindByEmail(string email)
        {
            var user = await _context.User.SingleOrDefaultAsync(u => u.Email == email);

            return user;
        }

        public async Task<User> FindByUsername(string userName)
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

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new DbUpdateConcurrencyException("Already modified. Try again");
            }

            return id;
        }
    }
}
