using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Services
{
    public interface IBreedService
    {
        Task<Breed> GetBreedById(int id);
        Task<List<Breed>> GetBreedsByName(string name);
        Task<List<Breed>> GetAllBreeds();
        Task<int> CreateBreed(Breed breed);
        Task<int> UpdateBreed(Breed breed);
        Task<int> DeleteBreed(int id);
    }
}
