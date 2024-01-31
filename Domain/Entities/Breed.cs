using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class Breed : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int SpeciesId { get; set; }
        public Species Species { get; set; } = null!;
        public HashSet<Pet> Pets { get; set; } = new HashSet<Pet>();
    }
}
