using System.ComponentModel.DataAnnotations;

namespace Deposito.Shared.Models.Model.Suppliers;

public class Supplier
{
    [Key]
    public int IdSupplier { get; set; }
    public string Name { get; set; }
    public string Tel { get; set; }
    public string Email { get; set; }




}
