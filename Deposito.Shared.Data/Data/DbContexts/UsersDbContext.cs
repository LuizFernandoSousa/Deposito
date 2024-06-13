using Deposito.Shared.Models.Model.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Deposito.Shared.Data.Data.DbContexts
{
    public class UsersDbContext : IdentityDbContext<Users>
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
        }

        DbSet<Users> Users {  get; set; }
    }
}
