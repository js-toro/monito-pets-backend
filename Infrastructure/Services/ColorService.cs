using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Interfaces;
using MonitoPetsBackend.Domain.Services;
using MonitoPetsBackend.Infrastructure.Common.Attributes;
using MonitoPetsBackend.Infrastructure.Common.Exceptions;
using System.Net;

namespace MonitoPetsBackend.Infrastructure.Services
{
    [ScopedRegistration]
    public class ColorService : IColorService
    {
        private readonly IColorRepository _repository;

        public ColorService(IColorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Color>> GetAllColors()
        {
            var colors = await _repository.GetAllColors();

            if (colors is null)
            {
                throw new ValidationException("No colors found", HttpStatusCode.NotFound);
            }

            return colors;
        }

        public async Task<Color?> GetColorById(int id)
        {
            var color = await _repository.GetColorById(id);

            if (color is null)
            {
                throw new ValidationException("Color not found", HttpStatusCode.NotFound);
            }

            return color;
        }

        public async Task<Color?> GetColorByName(string name)
        {
            var color = await _repository.GetColorByName(name);

            if (color is null)
            {
                throw new ValidationException("Color not found", HttpStatusCode.NotFound);
            }

            return color;
        }

        public async Task<bool> CreateColor(Color color)
        {
            var tryGetColor = await _repository.GetColorByName(color.Name);

            if (tryGetColor is not null)
            {
                throw new ValidationException("Color already exists", HttpStatusCode.Conflict);
            }

            var created = await _repository.CreateColor(color);

            if (created is false)
            {
                throw new ValidationException("An error occurred while creating the color", HttpStatusCode.BadRequest);
            }

            return true;
        }

        public async Task<bool> UpdateColor(Color color)
        {
            var tryGetColor = await _repository.GetColorById(color.Id);

            if (tryGetColor is null)
            {
                throw new ValidationException("Color not found", HttpStatusCode.NotFound);
            }

            var updated = await _repository.UpdateColor(color);

            if (updated is false)
            {
                throw new ValidationException("An error occurred while updating the color", HttpStatusCode.BadRequest);
            }

            return true;
        }

        public async Task<bool> DeleteColor(int id)
        {
            var tryGetColor = await _repository.GetColorById(id);

            if (tryGetColor is null)
            {
                throw new ValidationException("Color not found", HttpStatusCode.NotFound);
            }

            var deleted = await _repository.DeleteColor(id);

            if (deleted is false)
            {
                throw new ValidationException("An error occurred while deleting the color", HttpStatusCode.BadRequest);
            }

            return true;
        }
    }
}
