using MonitoPetsBackend.Domain.Common;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
        Task<List<User>> GetUsersByName(string name);
        Task<List<User>> GetUsersByState(bool isActive);
        Task<List<User>> GetAllUsers();
        Task<int> CreateUser(User user);
        Task<int> UpdateUser(User user);
        Task<int> DeleteUser(int id);
    }
}
