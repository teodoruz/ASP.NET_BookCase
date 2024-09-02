using BookCase_02.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCase_02.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AutorModel> AutorModels { get; set; }
        public DbSet<BookModel> Livro { get; set; } 

    }
}
