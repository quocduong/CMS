using AutoMapper;
using CMS.Base.Dto;
using CMS.Base.Dto.Menus;
using CMS.Base.Dto.Pages;
using CMS.EntityFramework.Domain;
using CMS.EntityFramework.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.EntityFramework.Repositories.Menus
{
    public class MenuRepository : Repository, IMenuRepository
    {
        private readonly IMapper _mapper;
        public MenuRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<List<CreateUpdateMenuModel>> CreateAsync(List<CreateUpdateMenuModel> pages)
        {
            await using var context = new DatabaseContext();
            var entities = _mapper.Map<List<Page>>(pages);
            context.Pages.AddRange(entities);
            await context.SaveChangesAsync();

            return _mapper.Map<List<CreateUpdateMenuModel>>(entities);
        }

        public async Task<int> DeleteAsync(List<Guid> ids)
        {
            await using var context = new DatabaseContext();
            var Pages = context.Pages.Where(x => ids.Contains(x.Id));
            context.Pages.RemoveRange(Pages);
            return await context.SaveChangesAsync();
        }

        public async Task<List<CreateMenu>> ReadAsync(FilterModel filter = null, PagerModel pager = null, SortingOption sorting = null, bool prefetchPageTag = false, bool prefetchPageCategory = false)
        {
            await using var context = new DatabaseContext();
            var table = Fetch(context.Pages, filter: filter);
            if (sorting != null)
                table = Sort(table, sorting);
            table = table.ApplyPaging(pager);
            if (prefetchPageTag)
            {
                table = table.Include(x => x.PageTags);
            }
            if(prefetchPageCategory)
            {
                table = table.Include(x => x.PageCategories);
            }
            return _mapper.Map<List<CreateMenu>>(await table.ToListAsync());
        }

        public async Task<List<CreateUpdateMenuModel>> UpdateAsync(List<CreateUpdateMenuModel> pageModels)
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
            return _mapper.Map<List<CreateUpdateMenuModel>>(entities);
        }
        #region Private Methods
        private IQueryable<Page> Fetch(IQueryable<Page> table, FilterModel filter = null)
        {
            if (filter != null)
            {
                if (!string.IsNullOrEmpty(filter.Keyword))
                {
                    var searchText = $"%{filter.Keyword}%";
                    table = table.Where(x => EF.Functions.Like(x.Title, searchText)
                                          || EF.Functions.Like(x.Description, searchText)
                                          || EF.Functions.Like(x.OgTitle, searchText)
                                          || EF.Functions.Like(x.OgDescription, searchText)
                                          || EF.Functions.Like(x.Content, searchText));
                }
            }
            return table;
        }

        private IQueryable<Page> Sort(IQueryable<Page> table, SortingOption sorting)
        {
            if (!string.IsNullOrEmpty(sorting.SortBy))
            {
                switch (sorting.SortBy)
                {
                    case nameof(PageViewModel.Title):
                        table = sorting.SortingDirection == SortingDirection.Asc
                                ? table.OrderBy(x => x.Title) : table.OrderByDescending(x => x.Title);
                        break;
                }
                table = sorting.SortingDirection == SortingDirection.Asc
                                ? table.OrderBy(x => x.UpdatedDate).ThenBy(x => x.CreatedDate)
                                : table.OrderByDescending(x => x.UpdatedDate).ThenByDescending(x => x.CreatedDate);
            }
            return table;
        }
        #endregion
    }
}
