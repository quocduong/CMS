using CMS.WebApi.Mvc.Models;
using Microsoft.EntityFrameworkCore;
namespace CMS.WebApi.Mvc.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
