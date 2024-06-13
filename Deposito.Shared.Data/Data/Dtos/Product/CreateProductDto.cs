using System.ComponentModel.DataAnnotations;

namespace Deposito.Shared.Data.Data.Dtos.Proxduct
{
    public class CreateProductDto
    {

        [Required(ErrorMessage = "Não possui quantidade")]
        public double Amout { get; set; }

        [Required(ErrorMessage = "Não possui peso.")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Não possui nome.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Não possui Preço.")]
        public double Price { get; set; }

    }
}
