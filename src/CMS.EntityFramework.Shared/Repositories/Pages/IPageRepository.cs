﻿using CMS.Base.Dto;
using CMS.Base.Dto.Pages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.EntityFramework.Repositories.Pages
{
    public interface IPageRepository : IRepository
    {
        Task<List<PageViewModel>> ReadAsync(FilterModel filter, PagerModel pager = null, SortingOption sorting = null);
        Task<List<CreateUpdatePageModel>> CreateAsync(List<CreateUpdatePageModel> pages);
        Task<List<CreateUpdatePageModel>> UpdateAsync(List<CreateUpdatePageModel> pageModels);
        Task<int> DeleteAsync(List<Guid> ids);
    }
}
