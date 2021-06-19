using CMS.EntityFramework.Domain;
using Microsoft.EntityFrameworkCore;

namespace CMS.EntityFramework
{
    public partial class CmsDbContext : DbContext
    {
        public CmsDbContext()
        {

        }
        public CmsDbContext(DbContextOptions<CmsDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-R7LVCL3\MSSQLSERVER2;initial catalog=CMS;uid=sa;pwd=123456;");
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}
