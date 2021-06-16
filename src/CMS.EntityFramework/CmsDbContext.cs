using CMS.EntityFramework.Domain;
using Microsoft.EntityFrameworkCore;

namespace CMS.EntityFramework
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions<CmsDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}
