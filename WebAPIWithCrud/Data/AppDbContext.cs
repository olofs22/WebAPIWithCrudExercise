using Microsoft.EntityFrameworkCore;
using WebAPIWithCrud.Models;

namespace WebAPIWithCrud.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Items> Items => Set<Items>();
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=WebAPIWithCrudDb;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=0");
        }*/
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

    }
}
