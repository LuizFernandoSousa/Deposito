using Microsoft.EntityFrameworkCore;
using Product.Model;
using Product.Data;

namespace Product.Data;

public class ProductDbContext : DbContext
{

    public ProductDbContext(DbContextOptions<ProductDbContext> opts) : base(opts) 
    {
    }


    public DbSet<Productsss> Products { get; set; }




}
