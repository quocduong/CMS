using CMS.EntityFramework.Domain;
using CMS.EntityFramework.Domain.Product;
using Microsoft.EntityFrameworkCore;

namespace CMS.EntityFramework
{
    public partial class CmsDbContext : DbContext
    {

        public CmsDbContext() : base()
        {

        }
        public CmsDbContext(DbContextOptions<CmsDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
