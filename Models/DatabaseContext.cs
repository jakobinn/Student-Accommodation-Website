using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StudentApartments.Models;

namespace StudentApartments.Models
{
	public class DatabaseContext : IdentityDbContext<User>
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
		{
		}

        public DbSet<User> User { get; set; }
        public DbSet<Apartment> Apartment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Apartment>()
                   //.HasOne(a => a.User)
                   //.HasForeignKey(a => a.IDOwner);
        }
    }

}