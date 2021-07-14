using CMS.Base.Dto.Menus;
using CMS.Business.Interfaces.Menus;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.GraphQL.Mutations
{
    public class Mutation
    {
        private readonly IMenuService _menuService;
        public Mutation(IMenuService menuService)
        {
            _menuService = menuService;
        }
        // Chưa có phần GEt dữ liệu
        public async Task<List<CreateUpdateMenuModel>> CreateMenu(List<CreateUpdateMenuModel> pages)
        {
            return pages;
        }
        public async Task<int> DeleteAsync(List<Guid> ids)
        {
            return await _menuService.DeleteAsync(ids);
        }
    }
}
