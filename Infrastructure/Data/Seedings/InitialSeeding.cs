using Microsoft.EntityFrameworkCore;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Infrastructure.Data.Seedings
{
    public class InitialSeeding
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            User admin = new() { Id = 1, Name = "Admin", Email = "admin@monito.pet", Password = "admin", IsActive = true };
            User common = new() { Id = 2, Name = "Common", Email = "common@monito.pet", Password = "common", IsActive = true };

            modelBuilder.Entity<User>().HasData(admin, common);

            Species cat = new() { Id = 1, Name = "Gato" };
            Species dog = new() { Id = 2, Name = "Perro" };
            Species bird = new() { Id = 3, Name = "Ave" };

            modelBuilder.Entity<Species>().HasData(cat, dog, bird);

            Breed persian = new() { Id = 1, Name = "Persa", SpeciesId = cat.Id };
            Breed siamese = new() { Id = 2, Name = "Siamés", SpeciesId = cat.Id };
            Breed bengali = new() { Id = 3, Name = "Bengalí", SpeciesId = cat.Id };
            Breed creole = new() { Id = 4, Name = "Criollo", SpeciesId = cat.Id };
            Breed bostonTerrier = new() { Id = 5, Name = "Boston Terrier", SpeciesId = dog.Id };
            Breed borderCollie = new() { Id = 6, Name = "Border Collie", SpeciesId = dog.Id };
            Breed bulldog = new() { Id = 7, Name = "Bulldog", SpeciesId = dog.Id };
            Breed chihuahua = new() { Id = 8, Name = "Chihuahua", SpeciesId = dog.Id };
            Breed canary = new() { Id = 9, Name = "Canario", SpeciesId = bird.Id };
            Breed parakeet = new() { Id = 10, Name = "Periquito", SpeciesId = bird.Id };
            Breed parrot = new() { Id = 11, Name = "Loro", SpeciesId = bird.Id };

            modelBuilder.Entity<Breed>().HasData(
                persian, 
                siamese, 
                bengali, 
                creole, 
                bostonTerrier, 
                borderCollie, 
                bulldog, 
                chihuahua, 
                canary, 
                parakeet, 
                parrot
                );

            Color white = new() { Id = 1, Name = "Blanco" };
            Color pecanBlack = new() { Id = 2, Name = "Negro Peceño" };
            Color blackJet = new() { Id = 3, Name = "Negro Hito" };
            Color landmarkBlack = new() { Id = 4, Name = "Negro Azabache" };
            Color darkBlue = new() { Id = 5, Name = "Azul Oscuro" };
            Color caoba = new() { Id = 6, Name = "Caoba" };
            Color red = new() { Id = 7, Name = "Rojizo" };
            Color yellow = new() { Id = 8, Name = "Amarillo" };
            Color orange = new() { Id = 9, Name = "Naranja" };
            Color brown = new() { Id = 10, Name = "Café" };
            Color gold = new() { Id = 11, Name = "Dorado" };
            Color chocolate = new() { Id = 12, Name = "Chocolate" };
            Color tabby = new() { Id = 13, Name = "Atigrado" };
            Color mottling = new() { Id = 14, Name = "Moteado" };

            modelBuilder.Entity<Color>().HasData(
                white,
                pecanBlack,
                blackJet,
                landmarkBlack,
                darkBlue,
                caoba,
                red,
                yellow,
                orange,
                brown,
                gold,
                chocolate,
                tabby,
                mottling
                );
        }
    }
}
