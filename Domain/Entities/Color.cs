using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class Color : BaseEntity
    {
        public string Name { get; set; } = null!;
        public HashSet<Pet> Pets { get; set; } = new HashSet<Pet>();
    }
}
