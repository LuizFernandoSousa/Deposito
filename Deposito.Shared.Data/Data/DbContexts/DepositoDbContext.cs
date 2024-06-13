using Deposito.Shared.Models.Model.Client;
using Deposito.Shared.Models.Model.Product;
using Deposito.Shared.Models.Model.Suppliers;
using Microsoft.EntityFrameworkCore;

namespace Deposito.Shared.Data.Data.DbContexts;

public class DepositoDbContext : DbContext
{
    public DepositoDbContext(DbContextOptions<DepositoDbContext> opts) : base(opts)
    {

    }

    public DbSet<Models.Model.Product.Product> Products { get; set; }
    public DbSet<Models.Model.Client.Clients> Clients { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }

}
