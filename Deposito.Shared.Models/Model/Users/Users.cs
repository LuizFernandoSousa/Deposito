using Microsoft.AspNetCore.Identity;

namespace Deposito.Shared.Models.Model.Users
{
    public class Users : IdentityUser
    {
        //UserName
        //Password
        //Email
        //EmailConfirmed
        //PasswordHash
        //PhoneNumber
        //

        public bool Isclient { get; set; }

        public Users() : base() { }




    }
}
