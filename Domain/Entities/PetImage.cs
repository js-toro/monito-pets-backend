using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class PetImage : AuditableEntityBase
    {
        public string Url { get; set; } = null!;
        public bool IsMain { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; } = null!;
    }
}
