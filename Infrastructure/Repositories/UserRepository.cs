using Microsoft.EntityFrameworkCore;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Interfaces;
using MonitoPetsBackend.Infrastructure.Common.Attributes;
using MonitoPetsBackend.Infrastructure.Data.Interfaces;

namespace MonitoPetsBackend.Infrastructure.Repositories
{
    [ScopedRegistration]
    public class UserRepository : IUserRepository
    {
        private readonly IApplicationDbContext _context;

        public UserRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<IEnumerable<User>> GetUsersByName(string name)
        {
            return await _context.Users.Where(user => user.Name.Contains(name)).ToListAsync();
        }

        public async Task<IEnumerable<User>> GetUsersBtState(bool isActive)
        {
           return await _context.Users.Where(user => user.IsActive == isActive).ToListAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<bool> CreateUser(User user)
        {
            _context.Users.Add(user);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateUser(User user)
        {
            _context.Users.Update(user);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteUser(int id)
        {
            return await _context.Users.Where(x => x.Id == id).ExecuteDeleteAsync() > 0;
        }
    }
}
