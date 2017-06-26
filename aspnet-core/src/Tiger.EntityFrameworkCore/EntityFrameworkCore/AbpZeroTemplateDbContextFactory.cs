using Tiger.Configuration;
using Tiger.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Tiger.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TigerDbContextFactory : IDbContextFactory<TigerDbContext>
    {
        public TigerDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<TigerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TigerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TigerConsts.ConnectionStringName));
            
            return new TigerDbContext(builder.Options);
        }
    }
}