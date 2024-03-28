using coronaApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace coronaApi
{
    public class DataContext : DbContext
    {
        public DbSet<Member> members { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-24EQMFH;Databasa=corona_DB");
        }

    }
}
