using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class PetStatistic : AuditableEntityBase
    {
        public int Views { get; set; }
        public int Likes { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; } = null!;
    }
}
