using System.ComponentModel.DataAnnotations;

namespace Deposito.Shared.Data.Data.Dtos.Suppliers;

public class CreateSupplierDtos
{
    [Required(ErrorMessage = "Precisa preencher a Name")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Precisa preencher o telefone")]
    public string Tel { get; set; }


    [Required(ErrorMessage = "Precisa preencher o email")]
    public string Email { get; set; }

}
