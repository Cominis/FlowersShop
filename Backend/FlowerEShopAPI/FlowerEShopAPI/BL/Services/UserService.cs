using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces;

namespace FlowerEShopAPI.BL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly Lazy<IValidation> _validation = null;
        public UserService(IUserRepository userRepository, Lazy<IValidation> validation)
        {
            _userRepository = userRepository;
            _validation = validation;
        }

        public async Task<User> CreateUser(string name, string email, string surname, string userName, string password)
        {
            await _validation.Value.ValidateUser(email, userName, password, false);

            var createdUser = await _userRepository.Create(name, email, surname, userName, password);

            return createdUser;
        }
        public async Task<User> UpdateUser(string id, string name, string email, string surname, string userName, string password)
        {
            await _validation.Value.ValidateUser(email, userName, password, true);
            var updatedUser = await _userRepository.Update(id, name, email, surname, userName, password);

            return updatedUser;
        }

        public async Task<User> GetUserById(string id)
        {
            var user = await _userRepository.FindOneById(id);

            return user;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _userRepository.FindByEmail(email);

            return user;
        }
    }
}
