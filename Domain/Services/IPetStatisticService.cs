using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Services
{
    public interface IPetStatisticService
    {
        Task<PetStatistic> GetPetStatisticById(int id);
        Task<List<PetStatistic>> GetAllPetStatistics();
        Task<int> CreatePetStatistic(PetStatistic petStatistic);
        Task<int> UpdatePetStatistic(PetStatistic petStatistic);
        Task<int> DeletePetStatistic(int id);
    }
}
