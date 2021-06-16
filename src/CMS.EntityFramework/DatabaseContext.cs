using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CMS.EntityFramework
{
    public class DatabaseContext : CmsDbContext
    {
        private DbConnection _connection;
        public DatabaseContext() : base() { }
        public DatabaseContext(DbConnection connection) : base()
        {
            _connection = connection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connection.ConnectionString);
        }
    }
}
