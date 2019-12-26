using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{

    public class MyDBContext : IdentityDbContext<ApplicationUser>
    {
        public MyDBContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static MyDBContext Create()
        {
            return new MyDBContext();
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<MembershipType> MembershipTypes { get; set; }

        public DbSet<Genre> Genre { get; set; }
    }

}