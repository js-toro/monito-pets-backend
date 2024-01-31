﻿using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IPetStatisticRepository
    {
        Task<PetStatistic> GetPetStatisticById(int id);
        Task<List<PetStatistic>> GetAllPetStatistics();
        Task<int> CreatePetStatistic(PetStatistic petStatistic);
        Task<int> UpdatePetStatistic(PetStatistic petStatistic);
        Task<int> DeletePetStatistic(int id);
    }
}
