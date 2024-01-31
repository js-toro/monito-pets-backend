﻿using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IPetImageRepository
    {
        Task<PetImage> GetPetImageById(int id);
        Task<List<PetImage>> GetPetImagesByPetId(int id);
        Task<List<PetImage>> GetAllPetImages();
        Task<int> CreatePetImage(PetImage petImage);
        Task<int> UpdatePetImage(PetImage petImage);
        Task<int> DeletePetImage(int id);
    }
}
