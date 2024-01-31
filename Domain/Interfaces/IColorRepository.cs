﻿using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Interfaces
{
    public interface IColorRepository
    {
        Task<Color> GetColorById(int id);
        Task<List<Color>> GetColorsByName(string name);
        Task<List<Color>> GetAllColors();
        Task<int> CreateColor(Color color);
        Task<int> UpdateColor(Color color);
        Task<int> DeleteColor(int id);
    }
}