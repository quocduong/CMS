using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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

        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddDebug(); });


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connection != null)
            {
                optionsBuilder.UseLoggerFactory(MyLoggerFactory)  //tie-up DbContext with LoggerFactory object
                    .EnableSensitiveDataLogging()
                    .UseSqlServer(_connection);
            }
            else
            {
                optionsBuilder.UseLoggerFactory(MyLoggerFactory)  //tie-up DbContext with LoggerFactory object
                    .EnableSensitiveDataLogging()
                    .UseSqlServer(@"Data Source=DESKTOP-R7LVCL3\MSSQLSERVER2;initial catalog=CMS;uid=sa;pwd=123456;");
            }
        }
    }
}
