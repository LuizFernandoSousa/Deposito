using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Shared.Data.Data.Dtos.Proxduct;

public class UpdateProductDto
{
    public double Amout { get; set; }

    public double Weight { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }
}
