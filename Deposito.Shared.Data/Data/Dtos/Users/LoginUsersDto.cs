using System.ComponentModel.DataAnnotations;

namespace Deposito.Shared.Data.Data.Dtos.Users
{
    public class LoginUsersDto
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
