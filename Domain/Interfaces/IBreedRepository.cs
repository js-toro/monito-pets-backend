using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IBreedRepository
    {
        Task<Breed> GetBreedById(int id);
        Task<List<Breed>> GetBreedsByName(string name);
        Task<List<Breed>> GetAllBreeds();
        Task CreateBreed(Breed breed);
        Task UpdateBreed(Breed breed);
        Task DeleteBreed(int id);
    }
}
