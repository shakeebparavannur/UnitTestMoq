using Microsoft.EntityFrameworkCore;
using UnitTestMoq.Models;

namespace UnitTestMoq.Data
{
    public class DbContextClass:DbContext
    {
        
        public DbContextClass(DbContextOptions<DbContextClass>options):base(options)
        {
            
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
