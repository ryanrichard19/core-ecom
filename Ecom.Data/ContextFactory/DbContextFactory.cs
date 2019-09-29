using System;
using System.Reflection;
using Ecom.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Ecom.Data.ContextFactory
{
    public class DbContextFactory : IDesignTimeDbContextFactory<EcomDbContext>
    {
        public EcomDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EcomDbContext>;
            var connection = @"Data Source=127.0.0.1,1433;Initial Catalog=Ecom;User ID=sa;Password=EcomSQL001;";
            builder.UseSqlServer(connection,
                builderOption =>
                    builderOption.MigrationsAssembly(typeof(EcomDbContext).GetTypeInfo().Assembly.GetName().Name));
            return new EcomDbContext(builder.Options);
        }
    }
}
