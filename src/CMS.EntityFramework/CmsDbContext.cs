using CMS.EntityFramework.Domain;
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
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<NewsNewsCategory> NewsNewsCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductProductCategory> ProductProductCategories { get; set; }
        public DbSet<ProductTagMapping> ProductTagMappings { get; set; }
        public DbSet<NewsTag> NewsTags { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageCategory> PageCategories { get; set; }
        public DbSet<PageContent> PageContents { get; set; }
        public DbSet<PageTag> PageTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
