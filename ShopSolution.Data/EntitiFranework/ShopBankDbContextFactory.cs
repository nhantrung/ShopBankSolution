using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopBankSolution.Data.EntitiFranework
{
    public class ShopBankDbContextFactory : IDesignTimeDbContextFactory<ShopBankDBContext>
    {
        public ShopBankDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopBankSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<ShopBankDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopBankDBContext(optionsBuilder.Options);
        }
    }
}
