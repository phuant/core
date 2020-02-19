using Microsoft.EntityFrameworkCore;

namespace NetCore.Model
{
    public class ConnectDatabase : DbContext
    {

        public ConnectDatabase( DbContextOptions<ConnectDatabase> options ) 
            :base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
