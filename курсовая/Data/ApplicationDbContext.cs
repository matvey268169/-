using Microsoft.EntityFrameworkCore;
using курсовая.Models;


namespace курсовая.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}