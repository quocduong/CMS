using CMS.Business.Interfaces;
using CMS.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CMS.Business
{
    public static class ServiceRegistration
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<ISingletonService, SingletonService>();
        }
    }
}
