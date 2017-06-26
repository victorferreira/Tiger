using Microsoft.EntityFrameworkCore;

namespace Tiger.EntityFrameworkCore
{
    public static class TigerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TigerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}