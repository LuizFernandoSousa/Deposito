﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DepositoDeBebidas.Model
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