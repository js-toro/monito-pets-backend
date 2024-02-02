using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Infrastructure.Data.Configuration
{
    public class PetImageConfiguration : AuditableEntityConfiguration<PetImage>
    {
        public override void Configure(EntityTypeBuilder<PetImage> builder)
        {
            base.Configure(builder);
        }
    }
}
