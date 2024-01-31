using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class Species : BaseEntity
    {
        public string Name { get; set; } = null!;
        public List<Breed> Breeds { get; set; } = new List<Breed>();
    }
}
