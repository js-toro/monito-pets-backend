namespace MonitoPetsBackend.Presentation.DTOs.User
{
    public class CreateUserRequestDTO
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
