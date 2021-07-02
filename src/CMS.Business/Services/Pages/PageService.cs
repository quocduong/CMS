using CMS.Base.Dto;
using CMS.Base.Dto.Pages;
using CMS.Business.Interfaces.Pages;
using CMS.EntityFramework.Repositories.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Business.Services.Pages
{
    public class PageService : BaseService, IPageService
    {
        private readonly IPageRepository _pageRepository;

        public PageService(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public async Task<List<PageViewModel>> ReadAsync(FilterModel filter = null, PagerModel pager = null, SortingOption sorting = null)
        {
            return await _pageRepository.ReadAsync(filter);
        }

        public async Task<List<CreateUpdatePageModel>> SaveAsync(List<CreateUpdatePageModel> pages)
        {
            var newItems = pages.Where(x => x.Id == null);
            var updatedItems = pages.Where(x => x.Id != null);
            var addItemsTask = _pageRepository.CreateAsync(newItems.ToList());
            var updateItemTask = _pageRepository.UpdateAsync(updatedItems.ToList());
            await Task.WhenAll(addItemsTask, updateItemTask);
            var addResult = await addItemsTask;
            addResult.AddRange(await updateItemTask);

            return addResult;
        }
        
        public async Task<int> DeleteAsync(List<Guid> ids)
        {
            return await _pageRepository.DeleteAsync(ids);
        }
    }
}
