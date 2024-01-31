﻿using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface ISpeciesRepository
    {
        Task<Species> GetSpeciesById(int id);
        Task<List<Species>> GetAllSpecies();
        Task<int> CreateSpecies(Species species);
        Task<int> UpdateSpecies(Species species);
        Task<int> DeleteSpecies(int id);
    }
}
