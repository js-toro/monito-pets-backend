namespace MonitoPetsBackend.Presentation.DTOs.User
{
    public class UpdateUserRequestDTO
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
