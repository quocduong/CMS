using CMS.Base.Dto;
using CMS.Base.Dto.Pages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.Business.Interfaces.Pages
{
    public interface IPageService : IBaseService
    {
        Task<List<PageViewModel>> ReadAsync(FilterModel filter = null, PagerModel pager = null, SortingOption sorting = null);
        Task<List<CreateUpdatePageModel>> SaveAsync(List<CreateUpdatePageModel> pages);
        Task<int> DeleteAsync(List<Guid> ids);
    }
}
