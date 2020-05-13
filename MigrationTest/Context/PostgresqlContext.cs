using Microsoft.EntityFrameworkCore;
using MigrationTest.Entities;

namespace MigrationTest.Context
{
    public class PostgresqlContext:DbContext
    {
        public PostgresqlContext(DbContextOptions<PostgresqlContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
