using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Infrastructure.Data.Configuration
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasOne(pet => pet.PetStatistic)
                .WithOne(petStatistic => petStatistic.Pet)
                .HasForeignKey<PetStatistic>(petStatistic => petStatistic.PetId);
            
            builder.HasOne(pet => pet.PetDetail)
                .WithOne(petDetail => petDetail.Pet)
                .HasForeignKey<PetDetail>(petDetail => petDetail.PetId);
        }
    }
}
