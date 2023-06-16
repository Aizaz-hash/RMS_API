using DemoSQLServer.Models;
using Microsoft.EntityFrameworkCore;


namespace DemoSQLServer.Data
{
    public class APIDbContext :DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Students> Students { get; set; }
    }
}
