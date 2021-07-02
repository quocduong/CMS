using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CMS.EntityFramework
{
    public static class RepositoryRegistration
    {
        public static void Register(IServiceCollection services)
        {
            var folderEnd = Assembly.GetExecutingAssembly().CodeBase.Length - 30;
            var workingDirectory = Assembly.GetExecutingAssembly().CodeBase[8..folderEnd];

            var allProviderTypes = new List<Type>();
            var dlls = new string[] { "CMS.EntityFramework.Shared.dll" };
            foreach (var dll in dlls)
            {
                var dllPath = workingDirectory + $@"/{dll}";
                if (!File.Exists(dllPath))
                    dllPath = dll;

                allProviderTypes.AddRange(Assembly.LoadFrom(dllPath).GetTypes().Where(t => t.Namespace != null && t.Namespace.Contains("Repositories")));
            }

            var providerTypes = allProviderTypes.ToArray();
            foreach (var intfc in providerTypes.Where(t => t.IsInterface))
            {
                var impl = providerTypes.FirstOrDefault(c => c.IsClass && intfc.Name.Substring(1) == c.Name);
                if (impl != null)
                    services.TryAddSingleton(intfc, impl);
            }
        }
    }
}
