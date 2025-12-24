namespace Backend.DTOs
{
    public class AuthResponseDto
    {
        public string Token { get; set; } = null!;
        public string FullName { get; set; } = null!;
    }
}
