using AutoMapper;
using CMS.Base.Dto;
using CMS.Base.Dto.Pages;
using CMS.EntityFramework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.EntityFramework.Repositories.Pages
{
    public class PageRepository : Repository, IPageRepository
    {
        private readonly IMapper _mapper;

        public PageRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<List<PageViewModel>> ReadAsync(FilterModel filter, PagerModel pager = null, SortingOption sorting = null)
        {
            await using var context = new DatabaseContext();
            var table = Fetch(context.Pages);
            var result = table.ToListAsync();
            return _mapper.Map<List<PageViewModel>>(result);
        }

        public async Task<List<CreateUpdatePageModel>> CreateAsync(List<CreateUpdatePageModel> pages)
        {
            await using var context = new DatabaseContext();
            var entities = _mapper.Map<List<Page>>(pages);
            context.Pages.AddRange(entities);
            await context.SaveChangesAsync();

            return _mapper.Map<List<CreateUpdatePageModel>>(entities);
        }

        public async Task<List<CreateUpdatePageModel>> UpdateAsync(List<CreateUpdatePageModel> pageModels)
        {
            await using var context = new DatabaseContext();
            var itemDictionary = pageModels.ToDictionary(x => x.Id);
            var entities = await context.Pages.Where(x => itemDictionary.Keys.ToList().Contains(x.Id)).ToListAsync();
            foreach (var item in entities)
            {
                if (itemDictionary.TryGetValue(item.Id, out var updatedItem))
                {
                    _mapper.Map(updatedItem, item);
                }
            }
            await context.SaveChangesAsync();

            return _mapper.Map<List<CreateUpdatePageModel>>(entities);
        }

        public async Task<int> DeleteAsync(List<Guid> ids)
        {
            await using var context = new DatabaseContext();
            var Pages = context.Pages.Where(x => ids.Contains(x.Id));
            context.Pages.RemoveRange(Pages);
            return await context.SaveChangesAsync();
        }

        #region Private Methods

        private IQueryable<Page> Fetch(IQueryable<Page> table)
        {
            return table;
        }

        #endregion
    }
}
