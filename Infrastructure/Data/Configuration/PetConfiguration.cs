using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Infrastructure.Data.Configuration
{
    public class PetConfiguration : AuditableEntityConfiguration<Pet>
    {
        public override void Configure(EntityTypeBuilder<Pet> builder)
        {
            base.Configure(builder);

            builder.Property(pet => pet.Label)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(pet => pet.BirthDate)
                .HasColumnType("date");

            builder.HasOne(pet => pet.PetStatistic)
                .WithOne(petStatistic => petStatistic.Pet)
                .HasForeignKey<PetStatistic>(petStatistic => petStatistic.PetId);
            
            builder.HasOne(pet => pet.PetDetail)
                .WithOne(petDetail => petDetail.Pet)
                .HasForeignKey<PetDetail>(petDetail => petDetail.PetId);
        }
    }
}
