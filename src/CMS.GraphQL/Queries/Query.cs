using CMS.Base.Dto;
using CMS.Base.Dto.Menus;
using CMS.Business.Interfaces.Menus;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.GraphQL.Queries
{
    public class Query
    {
        private readonly IMenuService _menuService;
        public Query(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public async Task<List<CreateMenu>> Menus()
        {
            return await _menuService.ReadAsync(filter: new FilterModel(), pager: new PagerModel(), sorting: new SortingOption());
        }
    }
}
