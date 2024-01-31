﻿using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IPetRepository
    {
        Task<Pet> GetPetById(int id);
        Task<List<Pet>> GetPetsByLabel(string label);
        Task<List<Pet>> GetPetsByUserId(int id);
        Task<List<Pet>> GetPetsByState(bool isActive);
        Task<List<Pet>> GetAllPets();
        Task<int> CreatePet(Pet pet);
        Task<int> UpdatePet(Pet pet);
        Task<int> DeletePet(int id);
    }
}
