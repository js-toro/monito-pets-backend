using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface ISpeciesRepository
    {
        Task<Species> GetSpeciesById(int id);
        Task<List<Species>> GetAllSpecies();
        Task CreateSpecies(Species species);
        Task UpdateSpecies(Species species);
        Task DeleteSpecies(int id);
    }
}
