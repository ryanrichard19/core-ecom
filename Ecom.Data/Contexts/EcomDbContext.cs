using System;
using Microsoft.EntityFrameworkCore;
using Ecom.Domain.Entities;

namespace Ecom.Data.Contexts
{
    public class EcomDbContext : DbContext
    {
        public EcomDbContext(DbContextOptions<EcomDbContext> builder)
            : base(builder) { }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connection = @"Data Source=127.0.0.1,1433;Initial Catalog=Ecom;User ID=sa;Password=EcomSQL001;";
            builder.UseSqlServer(connection);
        }

    }
}
