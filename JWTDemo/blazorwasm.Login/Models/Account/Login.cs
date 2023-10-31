using System.ComponentModel.DataAnnotations;

namespace blazorwasm.Login.Models.Account
{
    public class Login
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}