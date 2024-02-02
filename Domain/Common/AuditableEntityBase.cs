using MonitoPetsBackend.Domain.Entities;

namespace MonitoPetsBackend.Domain.Common
{
    public class AuditableEntityBase : EntityBase
    {
        public DateTime Created { get; set; }
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; } = null!;
        public DateTime LastModified { get; set; } = DateTime.Now;
        public int LastModifiedById { get; set; }
        public User LastModifiedBy { get; set; } = null!;
    }
}
