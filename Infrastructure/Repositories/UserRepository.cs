using Microsoft.EntityFrameworkCore;
using MonitoPetsBackend.Infrastructure.Interfaces;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Interfaces;

namespace MonitoPetsBackend.Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IApplicationDbContext _context;

        public UserRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Id == id);
        }

        public async Task<List<User>> GetUsersByName(string name)
        {
            return await _context.Users.Where(user => user.Name.Contains(name)).ToListAsync();
        }

        public async Task<List<User>> GetUsersByState(bool isActive)
        {
            return await _context.Users.Where(user => user.IsActive == isActive).ToListAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<int> CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            var alterRows = await _context.SaveChangesAsync();
            return alterRows;
        }

        public async Task<int> UpdateUser(User user)
        {
            _context.Users.Update(user);
            var alterRows = await _context.SaveChangesAsync();
            return alterRows;
        }

        public async Task<int> DeleteUser(int id)
        {
            var alterRows = await _context.Users.Where(user => user.Id == id).ExecuteDeleteAsync();
            return alterRows;
        }
    }
}
