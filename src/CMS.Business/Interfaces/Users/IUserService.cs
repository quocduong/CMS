using CMS.Base.Dto;
using CMS.Base.Dto.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.Business.Interfaces.Users
{
    public interface IUserService
    {
        Task<List<UserViewModel>> ReadAsync(FilterModel filter, PagerModel pagerModel = null, SortingOption sortingOption = null);
        Task<CreateUpdateUserModel> SaveAsync(CreateUpdateUserModel user);
        Task<int> DeleteAsync(List<Guid> ids);
    }
}
