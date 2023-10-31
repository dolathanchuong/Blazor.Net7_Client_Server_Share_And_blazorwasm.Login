using System.ComponentModel.DataAnnotations;

namespace blazorwasm.Login.Models.Account
{
    public class EditUser
    {
        [Required]
        public string FirstName { get; set; } = default!;

        [Required]
        public string LastName { get; set; } = default!;

        [Required]
        public string Username { get; set; } = default!;

        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; } = default!;

        public EditUser() { }

        public EditUser(User user)
        {
            FirstName = user.FirstName!;
            LastName = user.LastName!;
            Username = user.Username!;
        }
    }
}
