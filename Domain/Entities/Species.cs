using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class Species : BaseEntity
    {
        public string Name { get; set; } = null!;
        public HashSet<Breed> Breeds { get; set; } = new HashSet<Breed>();
    }
}
