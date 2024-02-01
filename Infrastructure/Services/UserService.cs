using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Interfaces;
using MonitoPetsBackend.Domain.Services;
using MonitoPetsBackend.Infrastructure.Attributes;

namespace MonitoPetsBackend.Infrastructure.Services
{
    [ScopedRegistration]
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }

        public async Task<List<User>> GetUsersByName(string name)
        {
            return await _userRepository.GetUsersByName(name);
        }

        public async Task<List<User>> GetUsersByState(bool isActive)
        {
            return await _userRepository.GetUsersByState(isActive);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<int> CreateUser(User user)
        {
            return await _userRepository.CreateUser(user);
        }

        public async Task<int> UpdateUser(User user)
        {
            return await _userRepository.UpdateUser(user);
        }

        public async Task<int> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }
    }
}
