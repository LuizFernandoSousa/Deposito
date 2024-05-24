using DepositoDeBebidas.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DepositoDeBebidas.Data
{
    public class UsersDbContext : IdentityDbContext<Users>
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options) 
        { 



        }
        



    }
}
