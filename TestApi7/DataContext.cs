

global using Microsoft.EntityFrameworkCore;

namespace TestApi7
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; } = null!;
    }
}
