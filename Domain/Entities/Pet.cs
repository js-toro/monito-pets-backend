using MonitoPetsBackend.Domain.Common;
using MonitoPetsBackend.Domain.Enums;

namespace MonitoPetsBackend.Domain.Entities
{
    public class Pet : AuditableEntityBase
    {
        public string Label { get; set; } = null!;
        public HashSet<PetImage> PetImages { get; set; } = new HashSet<PetImage>();
        public Gender Gender { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; } = null!;
        public int BreedId { get; set; }
        public Breed Breed { get; set; } = null!;
        public int PetDetailId { get; set; }
        public PetDetail PetDetail { get; set; } = null!;
        public int PetStatisticId { get; set; }
        public PetStatistic PetStatistic { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
    }
}
