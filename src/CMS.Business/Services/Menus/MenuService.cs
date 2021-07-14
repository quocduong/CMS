using CMS.Base.Dto;
using CMS.Base.Dto.Menus;
using CMS.Business.Interfaces.Menus;
using CMS.EntityFramework.Repositories.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Business.Services.Menus
{
    public class MenuService : BaseService, IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public async Task<int> DeleteAsync(List<Guid> ids)
        {
            return await _menuRepository.DeleteAsync(ids);
        }

        public async Task<List<CreateMenu>> ReadAsync(FilterModel filter = null, PagerModel pager = null, SortingOption sorting = null)
        {
            return await _menuRepository.ReadAsync(filter);
        }

        public async Task<List<CreateUpdateMenuModel>> SaveAsync(List<CreateUpdateMenuModel> pages)
        {
            var newItems = pages.Where(x => x.Id == null);
            var updatedItems = pages.Where(x => x.Id != null);
            var addItemsTask = _menuRepository.CreateAsync(newItems.ToList());
            var updateItemTask = _menuRepository.UpdateAsync(updatedItems.ToList());
            await Task.WhenAll(addItemsTask, updateItemTask);
            var addResult = await addItemsTask;
            addResult.AddRange(await updateItemTask);
            return addResult;
        }
    }
}
