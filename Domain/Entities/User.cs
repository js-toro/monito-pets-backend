using MonitoPetsBackend.Domain.Common;

namespace MonitoPetsBackend.Domain.Entities
{
    public class User : BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsActive { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}
