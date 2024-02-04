using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IColorRepository
    {
        Task<IEnumerable<Color>> GetAllColors();
        Task<Color?> GetColorById(int id);
        Task<Color?> GetColorByName(string name);
        Task<bool> CreateColor(Color color);
        Task<bool> UpdateColor(Color color);
        Task<bool> DeleteColor(int id);
    }
}
