using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class Species : EntityBase
    {
        public string Name { get; set; } = null!;
        public List<Breed> Breeds { get; set; } = new List<Breed>();
    }
}
