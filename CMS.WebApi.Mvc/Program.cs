using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using System.Collections.ObjectModel;
using System.Data;

namespace CMS.WebApi.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                   .AddJsonFile("appsettings.json")
                   .Build();

            var sinkOptions = new MSSqlServerSinkOptions
            {
                TableName = "Serilog_Logs"
            };

            var columnOptions = new ColumnOptions
            {
                AdditionalColumns = new Collection<SqlColumn>
                {
                    new SqlColumn {ColumnName = "AppName", PropertyName = "AppName", DataType = SqlDbType.NVarChar, DataLength = 200},
                    new SqlColumn {ColumnName = "SourceContext", PropertyName = "SourceContext", DataType = SqlDbType.NVarChar, DataLength = 4000  },
                    new SqlColumn {ColumnName = "EventType", PropertyName = "EventType", DataType = SqlDbType.NVarChar, DataLength = 200}
                }
            };

            var logger = new LoggerConfiguration()
                .WriteTo.MSSqlServer(
                    connectionString: configuration.GetConnectionString("DefaultConnection"),
                    sinkOptions: sinkOptions,
                    columnOptions: columnOptions,
                    restrictedToMinimumLevel: LogEventLevel.Warning
                )
                .ReadFrom.Configuration(configuration)
                .Enrich.WithProperty("AppName", "CMS.WebApi.Mvc")
                .WriteTo.Debug(LogEventLevel.Debug)
                .CreateLogger();

            Log.Logger = logger;
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
