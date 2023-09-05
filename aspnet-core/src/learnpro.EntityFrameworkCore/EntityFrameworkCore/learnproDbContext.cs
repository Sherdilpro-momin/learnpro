using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using learnpro.Authorization.Roles;
using learnpro.Authorization.Users;
using learnpro.MultiTenancy;

namespace learnpro.EntityFrameworkCore
{
    public class learnproDbContext : AbpZeroDbContext<Tenant, Role, User, learnproDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public learnproDbContext(DbContextOptions<learnproDbContext> options)
            : base(options)
        {
        }
    }
}
