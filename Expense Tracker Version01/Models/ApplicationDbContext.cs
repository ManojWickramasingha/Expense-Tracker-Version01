using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace Expense_Tracker_Version01.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {}

        public DbSet <Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
