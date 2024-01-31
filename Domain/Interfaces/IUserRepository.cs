using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
        Task<List<User>> GetUsersByName(string name);
        Task<List<User>> GetUsersByState(bool isActive);
        Task<List<User>> GetAllUsers();
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}
