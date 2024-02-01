using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class Color : EntityBase
    {
        public string Name { get; set; } = null!;
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}
