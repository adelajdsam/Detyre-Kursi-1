using Book_Review_test1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Review_test1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Book> Books { get; set; }
    }
}
