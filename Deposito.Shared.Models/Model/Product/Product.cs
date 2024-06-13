using System.ComponentModel.DataAnnotations;

namespace Deposito.Shared.Models.Model.Product;

public class Product
{
    [Key]
    public int IdProduct { get; set; }

    public double Amout { get; set; }

    public double Weight { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }


}
