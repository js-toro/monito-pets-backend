using MonitoPetsBackend.Domain.Common;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<IEnumerable<User>> GetUsersByName(string name);
        Task<IEnumerable<User>> GetUsersBtState(bool isActive);
        Task<User?> GetUserById(int id);
        Task<User?> GetUserByEmail(string email);
        Task<bool> CreateUser(User user);
        Task<bool> UpdateUser(User user);
        Task<bool> DeleteUser(int id);
    }
}
