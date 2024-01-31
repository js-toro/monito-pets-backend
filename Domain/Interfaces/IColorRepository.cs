using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IColorRepository
    {
        Task<Color> GetColorById(int id);
        Task<List<Color>> GetColorsByName(string name);
        Task<List<Color>> GetAllColors();
        Task CreateColor(Color color);
        Task UpdateColor(Color color);
        Task DeleteColor(int id);
    }
}