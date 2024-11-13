using Microsoft.EntityFrameworkCore;
using azure_app_albi.Data;

namespace azure_app_trev_vs.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
