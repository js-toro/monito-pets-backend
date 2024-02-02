using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Infrastructure.Data.Configuration
{
    public class PetStatisticConfiguration : AuditableEntityConfiguration<PetStatistic>
    {
        public override void Configure(EntityTypeBuilder<PetStatistic> builder)
        {
            base.Configure(builder);
        }
    }
}
