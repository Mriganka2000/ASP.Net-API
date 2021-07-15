using Microsoft.EntityFrameworkCore;
using My_Book_API.Data.Models;

namespace My_Book_API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}