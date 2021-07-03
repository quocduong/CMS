using CMS.Business;
using CMS.EntityFramework;
using CMS.EntityFramework.Helpers;
using CMS.EntityFramework.Repositories;
using CMS.GraphQL.Mutations;
using CMS.GraphQL.Queries;
using CMS.Shared.Configurations;
using CMS.Web.Mvc.Resource;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CMS.Web.Mvc
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        public Startup(IWebHostEnvironment env)
        {
            _env = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            this.Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CmsDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();

            var connectionSettings = new AppSettings();
            Configuration.Bind("ConnectionStrings", connectionSettings);
            services.AddSingleton(connectionSettings);

            RegisterDI(services);
            services.AddScoped<IWebResourceManager, WebResourceManager>();
            services.AddSingleton(typeof(ScriptPaths));

            if (bool.Parse(Configuration["GraphQL:IsEnabled"]))
            {
                services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();
            }

            services.AddSignalR();
            services.AddMvc();
            services.AddWebOptimizer();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var enabledGraphQl =  bool.Parse(Configuration["GraphQL:IsEnabled"]);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                if (enabledGraphQl)
                {
                    app.UsePlayground(new PlaygroundOptions
                    {
                        QueryPath = "/api",
                        Path = "/playground"
                    });
                }
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            if (enabledGraphQl)
            {
                app.UseGraphQL("/api");
            }
            app.UseWebOptimizer();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void RegisterDI(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingHelper));
            ServiceRegistration.Register(services);
            RepositoryRegistration.Register(services);
        }
    }
}
