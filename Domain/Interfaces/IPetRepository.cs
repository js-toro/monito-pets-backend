using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Enums;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IPetRepository
    {
        Task<Pet> GetPetById(int id);
        Task<List<Pet>> GetPetsByLabel(string label);
        Task<List<Pet>> GetPetsByUserId(int id);
        Task<List<Pet>> GetPetsByState(bool isActive);
        Task<List<Pet>> GetAllPets();
        Task CreatePet(Pet pet);
        Task UpdatePet(Pet pet);
        Task DeletePet(int id);
    }
}
