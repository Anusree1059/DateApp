using Microsoft.EntityFrameworkCore;
using DateApp.API.Models;

namespace anusrees.DateApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}