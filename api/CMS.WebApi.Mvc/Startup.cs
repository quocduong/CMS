using CMS.WebApi.Mvc.Adapters;
using CMS.WebApi.Mvc.Core;
using CMS.WebApi.Mvc.GraphQL;
using CMS.WebApi.Mvc.GraphQL.Filters;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CMS.WebApi.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CMS.WebApi.Mvc", Version = "v1" });
            });
            services.AddSingleton<IAuthorService, InMemoryAuthorService>();
            services.AddSingleton<IBookService, InMemoryBookService>();

            services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();//.AddSubscriptionType<Subscription>();

            services.AddErrorFilter<BookNotFoundExceptionFilter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CMS.WebApi.Mvc v1"));
                app.UsePlayground(new PlaygroundOptions
                {
                    QueryPath = "/api",
                    Path = "/playground"
                });
            }

            app.UseHttpsRedirection();

            app.UseGraphQL("/api");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
