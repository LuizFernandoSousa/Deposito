using Microsoft.EntityFrameworkCore;
using Product.Model;

namespace Product.Data;

public class ProductDbContext : DbContext
{

    public ProductDbContext(DbContextOptions<ProductDbContext> opts) : base(opts) 
    {
    }


    public DbSet<Products> Products { get; set; }




}
