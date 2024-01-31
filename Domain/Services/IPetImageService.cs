using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Services
{
    public interface IPetImageService
    {
        Task<PetImage> GetPetImageById(int id);
        Task<List<PetImage>> GetPetImagesByPetId(int id);
        Task<List<PetImage>> GetAllPetImages();
        Task<int> CreatePetImage(PetImage petImage);
        Task<int> UpdatePetImage(PetImage petImage);
        Task<int> DeletePetImage(int id);
    }
}
