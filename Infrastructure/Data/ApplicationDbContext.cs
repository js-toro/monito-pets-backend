using Microsoft.EntityFrameworkCore;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Infrastructure.Common.Attributes;
using MonitoPetsBackend.Infrastructure.Data.Interfaces;
using MonitoPetsBackend.Infrastructure.Data.Seedings;
using System.Reflection;

namespace MonitoPetsBackend.Infrastructure.Data
{
    [ScopedRegistration]
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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            InitialSeeding.SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public async Task<int> SaveChangesAsync() => await base.SaveChangesAsync();
    }
}
