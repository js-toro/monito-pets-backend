using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Interfaces;
using MonitoPetsBackend.Domain.Services;
using MonitoPetsBackend.Infrastructure.Common.Attributes;
using MonitoPetsBackend.Infrastructure.Common.Exceptions;
using System.Net;

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

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsers();

            if (users is null)
            {
                throw new ValidationException("No users found", HttpStatusCode.NotFound);
            }

            return users;
        }

        public async Task<IEnumerable<User>> GetUsersByName(string name)
        {
            var users = await _userRepository.GetUsersByName(name);

            if (users is null)
            {
                throw new ValidationException("No users found", HttpStatusCode.NotFound);
            }

            return users;
        }

        public async Task<IEnumerable<User>> GetUsersBtState(bool isActive)
        {
            var users = await _userRepository.GetUsersBtState(isActive);

            if (users is null)
            {
                throw new ValidationException("No users found", HttpStatusCode.NotFound);
            }

            return users;
        }

        public async Task<User?> GetUserById(int id)
        {
            var user = await _userRepository.GetUserById(id);

            if (user is null)
            {
                throw new ValidationException("User not found", HttpStatusCode.NotFound);
            }

            return user;
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            var user = await _userRepository.GetUserByEmail(email);

            if (user is null)
            {
                throw new ValidationException("User not found", HttpStatusCode.NotFound);
            }

            return await _userRepository.GetUserByEmail(email);
        }

        public async Task<bool> CreateUser(User user)
        {
            var tryGetUser = await _userRepository.GetUserByEmail(user.Email);

            if (tryGetUser is not null)
            {
                throw new ValidationException("User already exists", HttpStatusCode.Conflict);
            }

            var created = await _userRepository.CreateUser(user);

            if (created is false)
            {
                throw new ValidationException("An error occurred while creating the user", HttpStatusCode.BadRequest);
            }

            return true;
        }

        public async Task<bool> UpdateUser(User user)
        {
            var tryGetUser = await _userRepository.GetUserById(user.Id);

            if (tryGetUser is not null)
            {
                throw new ValidationException("User not found", HttpStatusCode.NotFound);
            }

            var updated = await _userRepository.UpdateUser(user);

            if (updated is false)
            {
                throw new ValidationException("An error occurred while updating the user", HttpStatusCode.BadRequest);
            }

            return true;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var tryGetUser = await _userRepository.GetUserById(id);

            if (tryGetUser is not null)
            {
                throw new ValidationException("User not found", HttpStatusCode.NotFound);
            }

            var deleted = await _userRepository.DeleteUser(id);

            if (deleted is false)
            {
                throw new ValidationException("An error occurred while deleting the user", HttpStatusCode.BadRequest);
            }

            return true;
        }
    }
}
