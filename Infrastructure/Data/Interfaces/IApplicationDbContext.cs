using Microsoft.EntityFrameworkCore;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Infrastructure.Data.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Color> Colors { get; }
        DbSet<Breed> Breeds { get; }
        DbSet<Species> Species { get; }
        DbSet<Pet> Pets { get; }
        DbSet<PetDetail> PetDetails { get; }
        DbSet<PetImage> PetImages { get; }
        DbSet<PetStatistic> PetStatistic { get; }
        DbSet<User> Users { get; }

        Task<int> SaveChangesAsync();
    }
}
