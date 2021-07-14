using CMS.Base.Dto;
using CMS.Base.Dto.Menus;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.Business.Interfaces.Menus
{
    public interface IMenuService : IBaseService
    {
        Task<List<CreateMenu>> ReadAsync(FilterModel filter = null, PagerModel pager = null, SortingOption sorting = null);
        Task<List<CreateUpdateMenuModel>> SaveAsync(List<CreateUpdateMenuModel> pages);
        Task<int> DeleteAsync(List<Guid> ids);
    }
}
