using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class PetDetail : BaseAuditableEntity
    {
        public decimal Price { get; set; }
        public bool? IsVaccinated { get; set; }
        public bool? IsDewormed { get; set; }
        public bool? IsSterilized { get; set; }
        public bool? HasMicrochip { get; set; }
        public string Address { get; set; } = null!;
        public string AdditionalInfo { get; set; } = null!;
        public int PetId { get; set; }
        public Pet Pet { get; set; } = null!;
    }
}
