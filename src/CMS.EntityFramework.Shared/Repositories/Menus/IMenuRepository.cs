using CMS.Base.Dto;
using CMS.Base.Dto.Menus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CMS.EntityFramework.Repositories.Menus
{
    public interface IMenuRepository : IRepository 
    {
        Task<List<CreateMenu>> ReadAsync(FilterModel filter = null, PagerModel pager = null, SortingOption sorting = null,
            bool prefetchPageTag = false, bool prefetchPageCategory = false);
        Task<List<CreateUpdateMenuModel>> CreateAsync(List<CreateUpdateMenuModel> pages);
        Task<List<CreateUpdateMenuModel>> UpdateAsync(List<CreateUpdateMenuModel> pageModels);
        Task<int> DeleteAsync(List<Guid> ids);
    }
}
