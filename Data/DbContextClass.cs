using Microsoft.EntityFrameworkCore;
using UnitTestMoqFinal.Models;

namespace UnitTestMoqFinal.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

    }
}
