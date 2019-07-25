using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TheStore.Data
{
  public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
  {
    public StoreContext CreateDbContext(string[] args)
    {
      // Create a configuration 
      var builder = new WebHostBuilder();
      var config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("config.json")
        .Build();

      return new StoreContext(new DbContextOptionsBuilder<StoreContext>().Options, config);
    }
  }
}
