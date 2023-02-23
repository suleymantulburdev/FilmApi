using Microsoft.EntityFrameworkCore;

namespace FilmApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Drivers> Drivers { get; set; }
    }
}
