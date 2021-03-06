using Microsoft.EntityFrameworkCore;
using FirstMVC.Models;
 
namespace FirstMVC.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
 
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>().HasData(
                new Friend{Id=1,Name="Mary",Email="mary@gmail.com",Mobile="0922-355822"},
                new Friend{Id=2,Name="David",Email="david@gmail.com",Mobile="0933-355822"},
                new Friend{Id=3,Name="Rose",Email="rose@gmail.com",Mobile="0944-355822"}

            );
        }
    }
}
 
 
