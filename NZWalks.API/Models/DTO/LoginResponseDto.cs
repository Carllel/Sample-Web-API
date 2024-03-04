namespace NZWalks.API.Models.DTO
{
    public class LoginResponseDto
    {
        public bool isSuccessful { get; set; }
        public string? Token { get; set; }
    }
}
