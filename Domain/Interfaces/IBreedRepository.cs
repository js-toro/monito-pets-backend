﻿using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IBreedRepository
    {
        Task<Breed> GetBreedById(int id);
        Task<List<Breed>> GetBreedsByName(string name);
        Task<List<Breed>> GetAllBreeds();
        Task<int> CreateBreed(Breed breed);
        Task<int> UpdateBreed(Breed breed);
        Task<int> DeleteBreed(int id);
    }
}
