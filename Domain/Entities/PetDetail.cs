using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class PetDetail : AuditableEntityBase
    {
        public bool? IsVaccinated { get; set; }
        public bool? IsDewormed { get; set; }
        public bool? IsSterilized { get; set; }
        public bool? HasMicrochip { get; set; }
        public string? Address { get; set; }
        public string? AdditionalInfo { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; } = null!;
    }
}
