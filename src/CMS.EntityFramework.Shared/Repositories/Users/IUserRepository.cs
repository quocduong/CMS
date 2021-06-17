using CMS.Base.Dto;
using CMS.Base.Dto.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.EntityFramework.Repositories.Users
{
    public interface IUserRepository
    {
        Task<List<UserViewModel>> ReadAsync(FilterModel filter, PagerModel pager = null, SortingOption sorting = null);
        Task<List<CreateUpdateUserModel>> CreateAsync(List<CreateUpdateUserModel> users);
        Task<List<CreateUpdateUserModel>> UpdateAsync(List<CreateUpdateUserModel> userModels);
        Task<int> DeleteAsync(List<Guid> ids);
    }
}
