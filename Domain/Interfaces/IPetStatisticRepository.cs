using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IPetStatisticRepository
    {
        Task<PetStatistic> GetPetStatisticById(int id);
        Task<List<PetStatistic>> GetAllPetStatistics();
        Task CreatePetStatistic(PetStatistic petStatistic);
        Task UpdatePetStatistic(PetStatistic petStatistic);
        Task DeletePetStatistic(int id);
    }
}
