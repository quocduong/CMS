using CMS.Business.Interfaces.Pages;
using CMS.Business.Interfaces.Users;
using CMS.Business.Services.Pages;
using CMS.Business.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace CMS.Business
{
    public static class ServiceRegistration
    {
        public static void Register(IServiceCollection services)
        {
            RegisterSingletonServices(services);
        }

        private static void RegisterSingletonServices(IServiceCollection services)
        {
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<IUserService, UserService>();
        }
    }
}
