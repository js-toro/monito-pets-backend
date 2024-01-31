using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Services
{
    public interface IUserService
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
