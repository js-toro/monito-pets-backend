using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Infrastructure.Data.Configuration
{
    public class PetDetailConfiguration : AuditableEntityConfiguration<PetDetail>
    {
        public override void Configure(EntityTypeBuilder<PetDetail> builder)
        {
            base.Configure(builder);

            builder.Property(petDetail => petDetail.Address)
                .HasMaxLength(255);

            builder.Property(petDetail => petDetail.AdditionalInfo)
                .HasMaxLength(255);
        }
    }
}
