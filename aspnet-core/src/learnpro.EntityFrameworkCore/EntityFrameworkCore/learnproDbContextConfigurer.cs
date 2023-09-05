using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace learnpro.EntityFrameworkCore
{
    public static class learnproDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<learnproDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<learnproDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
