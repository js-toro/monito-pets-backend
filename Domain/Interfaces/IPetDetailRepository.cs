﻿using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IPetDetailRepository
    {
        Task<PetDetail> GetPetDetailById(int id);
        Task<List<PetDetail>> GetPetDetailsByPriceRange(decimal min, decimal max);
        Task<List<PetDetail>> GetAllPetDetails();
        Task<int> CreatePetDetail(PetDetail petDetail);
        Task<int> UpdatePetDetail(PetDetail petDetail);
        Task<int> DeletePetDetail(int id);
    }
}
