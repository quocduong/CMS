using CMS.Base.Dto;
using System.Linq;

namespace CMS.EntityFramework.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> table, PagerModel page)
        {
            if (page == null) return table;

            var pageNumber = page.PageIndex;
            if (pageNumber < 1)
                pageNumber = 1;

            return table.Skip((pageNumber - 1) * page.PageSize).Take(page.PageSize);
        }
    }
}
