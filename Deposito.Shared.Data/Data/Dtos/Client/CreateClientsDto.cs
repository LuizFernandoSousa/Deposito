using System.ComponentModel.DataAnnotations;

namespace Deposito.Shared.Data.Data.Dtos.Client;

public class CreateClientsDto
{
    [Required(ErrorMessage = "Precisa preencher a razão social")]
    public string SocialReason { get; set; }


    [Required(ErrorMessage = "Precisa preencher o telefone")]
    public string Tel { get; set; }


    [Required(ErrorMessage = "Precisa preencher o email")]
    public string Email { get; set; }

}
