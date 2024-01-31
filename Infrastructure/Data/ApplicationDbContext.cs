using Microsoft.EntityFrameworkCore;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Infrastructure.Interfaces;

namespace MonitoPetsBackend.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Color> Colors => Set<Color>();
        public DbSet<Breed> Breeds => Set<Breed>();
        public DbSet<Species> Species => Set<Species>();
        public DbSet<Pet> Pets => Set<Pet>();
        public DbSet<PetDetail> PetDetails => Set<PetDetail>();
        public DbSet<PetImage> PetImages => Set<PetImage>();
        public DbSet<PetStatistic> PetStatistic => Set<PetStatistic>();
        public DbSet<User> Users => Set<User>();
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public async Task<int> SaveChangesAsync() => await base.SaveChangesAsync();
    }
}
