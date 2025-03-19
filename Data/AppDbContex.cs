using Microsoft.EntityFrameworkCore;

namespace azure_app_trev_vs.Data
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}
