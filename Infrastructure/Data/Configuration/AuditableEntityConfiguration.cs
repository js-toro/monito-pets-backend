using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonitoPetsBackend.Domain.Common;
using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Infrastructure.Data.Configuration
{
    public class AuditableEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : AuditableEntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(entity => entity.Created)
                .HasColumnType("date");

            builder.HasOne(entity => entity.CreatedBy)
                .WithMany()
                .HasForeignKey(entity => entity.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(entity => entity.LastModified)
                .HasColumnType("date");

            builder.HasOne(entity => entity.LastModifiedBy)
                .WithMany()
                .HasForeignKey(entity => entity.LastModifiedById)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
