using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Models.Employees;

namespace MyCompany.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<User> Users { get; set; }
    }
}
