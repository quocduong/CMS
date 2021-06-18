using CMS.EntityFramework.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CMS.EntityFramework
{
    public static class RepositoryRegistration
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<IRepository, Repository>();
        }
    }
}
