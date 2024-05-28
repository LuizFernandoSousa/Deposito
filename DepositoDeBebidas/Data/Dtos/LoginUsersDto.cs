using System.ComponentModel.DataAnnotations;

namespace DepositoDeBebidas.Data.Dtos
{
    public class LoginUsersDto
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
