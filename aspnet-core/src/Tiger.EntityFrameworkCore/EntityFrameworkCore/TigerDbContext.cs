using Abp.Zero.EntityFrameworkCore;
using Tiger.Authorization.Roles;
using Tiger.Authorization.Users;
using Tiger.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Tiger.EntityFrameworkCore
{
    public class TigerDbContext : AbpZeroDbContext<Tenant, Role, User, TigerDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public TigerDbContext(DbContextOptions<TigerDbContext> options)
            : base(options)
        {

        }
    }
}
