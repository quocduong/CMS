using CMS.Shared.Resources;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Collections.Generic;

namespace CMS.Web.Mvc.Resource
{
    public interface IWebResourceManager
    {
        void AddScript(string url, bool addMinifiedOnProd = true);

        void AddScriptTag(string url, List<NameValue> attributes);

        IReadOnlyList<string> GetScripts();

        HelperResult RenderScripts();
    }
}
