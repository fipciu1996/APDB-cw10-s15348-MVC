using Microsoft.EntityFrameworkCore;

namespace APBD_10.Data
{
    public class APBD_10Context : DbContext
    {
        public APBD_10Context(DbContextOptions<APBD_10Context> options)
            : base(options)
        {
        }

        public DbSet<APBD_10.Models.Movie> Movie { get; set; }
    }
}
