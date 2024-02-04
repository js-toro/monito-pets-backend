using Microsoft.EntityFrameworkCore;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Interfaces;
using MonitoPetsBackend.Infrastructure.Common.Attributes;
using MonitoPetsBackend.Infrastructure.Data.Interfaces;

namespace MonitoPetsBackend.Infrastructure.Repositories
{
    [ScopedRegistration]
    public class ColorRepository : IColorRepository
    {
        private readonly IApplicationDbContext _context;

        public ColorRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Color>> GetAllColors()
        {
            return await _context.Colors.ToListAsync();
        }

        public async Task<Color?> GetColorById(int id)
        {
            return await _context.Colors.FirstOrDefaultAsync(color => color.Id == id);
        }

        public async Task<Color?> GetColorByName(string name)
        {
            return await _context.Colors.FirstOrDefaultAsync(color => color.Name == name);
        }

        public async Task<bool> CreateColor(Color color)
        {
            _context.Colors.Add(color);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateColor(Color color)
        {
            _context.Colors.Update(color);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteColor(int id)
        {
            return await _context.Colors.Where(color => color.Id == id).ExecuteDeleteAsync() > 0;
        }
    }
}
