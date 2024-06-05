using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data.Dtos;

public class CreateSupplierDtos
{
    [Required (ErrorMessage ="Precisa preencher a Name")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Precisa preencher o telefone")]
    public string Tel { get; set; }


    [Required (ErrorMessage ="Precisa preencher o email")]
    public string Email { get; set; }

}
