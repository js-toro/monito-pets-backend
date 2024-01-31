using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Services
{
    public interface ISpeciesService
    {
        Task<Species> GetSpeciesById(int id);
        Task<List<Species>> GetAllSpecies();
        Task<int> CreateSpecies(Species species);
        Task<int> UpdateSpecies(Species species);
        Task<int> DeleteSpecies(int id);
    }
}
