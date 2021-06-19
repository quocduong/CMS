using CMS.Shared.Extensions;
using Microsoft.AspNetCore.Mvc.Razor;

namespace CMS.Web.Mvc.AspNetCore.Mvc.Views
{
    public abstract class CmsRazorPage<TModel> : RazorPage<TModel>
    {
        public string ApplicationPath
        {
            get
            {
                var appPath = Context.Request.PathBase.Value;
                if (appPath == null)
                {
                    return "/";
                }

                appPath = appPath.EnsureEndsWith('/');

                return appPath;
            }
        }
    }
}
