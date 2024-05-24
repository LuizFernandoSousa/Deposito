﻿using System.ComponentModel.DataAnnotations;

namespace DepositoDeBebidas.Data.Dtos
{
    public class CreateUsersDto
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Nome é obrigátorio")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Senha é obrigatório")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Telefone é obrigatório")]
        public string Tel { get; set; }



    }
}
