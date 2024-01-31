using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IPetImageRepository
    {
        Task<PetImage> GetPetImageById(int id);
        Task<List<PetImage>> GetPetImagesByPetId(int id);
        Task<List<PetImage>> GetAllPetImages();
        Task CreatePetImage(PetImage petImage);
        Task UpdatePetImage(PetImage petImage);
        Task DeletePetImage(int id);
    }
}
