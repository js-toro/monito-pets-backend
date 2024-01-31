using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Enums;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IPetDetailRepository
    {
        Task<PetDetail> GetPetDetailById(int id);
        Task<List<PetDetail>> GetPetDetailsByPriceRange(decimal min, decimal max);
        Task<List<PetDetail>> GetAllPetDetails();
        Task CreatePetDetail(PetDetail petDetail);
        Task UpdatePetDetail(PetDetail petDetail);
        Task DeletePetDetail(int id);
    }
}
