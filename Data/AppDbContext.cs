using Microsoft.EntityFrameworkCore;
using ProductCrud_CodeWithPushpa.Models;
using System.Collections.Generic;

namespace ProductCrud_CodeWithPushpa.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
