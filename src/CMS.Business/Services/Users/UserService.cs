using CMS.Base.Dto;
using CMS.Base.Dto.Users;
using CMS.Business.Interfaces.Users;
using CMS.EntityFramework.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Business.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserViewModel>> ReadAsync(FilterModel filter, PagerModel pagerModel = null, SortingOption sortingOption = null)
        {
            return await _userRepository.ReadAsync(filter, pager: pagerModel, sorting: sortingOption);
        }

        public async Task<CreateUpdateUserModel> SaveAsync(CreateUpdateUserModel user)
        {
            return user.Id != null
                ? (await _userRepository.UpdateAsync(new List<CreateUpdateUserModel> { user })).FirstOrDefault()
                : (await _userRepository.UpdateAsync(new List<CreateUpdateUserModel> { user })).FirstOrDefault();
        }

        public async Task<int> DeleteAsync(List<Guid> ids)
        {
            return await _userRepository.DeleteAsync(ids);
        }
    }
}
