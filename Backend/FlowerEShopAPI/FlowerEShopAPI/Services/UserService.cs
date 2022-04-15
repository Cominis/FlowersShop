using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using FlowerEShopAPI.Services.ServiceInterfaces;

namespace FlowerEShopAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUser(string name, string surname, string userName, string password)
        {
            var createdUser = await _userRepository.Create(name, surname, userName, password);

            return createdUser;
        }


        public async Task<User> GetUserById(string id)
        {
            var user = await _userRepository.FindOneById(id);

            return user;
        }

        public async Task<User> GetUserByUserName(string userName)
        {
            var user = await _userRepository.FindOne(userName);

            return user;
        }
    }
}
