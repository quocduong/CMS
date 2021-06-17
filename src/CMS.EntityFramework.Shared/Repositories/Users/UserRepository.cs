using AutoMapper;
using System.Threading.Tasks;
using System.Linq;
using CMS.EntityFramework.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CMS.Base.Dto.Users;
using System;
using CMS.Base.Dto;

namespace CMS.EntityFramework.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        public UserRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<List<UserViewModel>> ReadAsync(FilterModel filter, PagerModel pager = null, SortingOption sorting = null)
        {
            await using var context = new DatabaseContext();
            var table = Fetch(context.Users);
            var result = table.ToListAsync();
            return _mapper.Map<List<UserViewModel>>(result);
        }

        public async Task<List<CreateUpdateUserModel>> CreateAsync(List<CreateUpdateUserModel> users)
        {
            await using var context = new DatabaseContext();
            var entities = _mapper.Map<List<User>>(users);
            context.Users.AddRange(entities);
            await context.SaveChangesAsync();

            return _mapper.Map<List<CreateUpdateUserModel>>(entities);
        }

        public async Task<List<CreateUpdateUserModel>> UpdateAsync(List<CreateUpdateUserModel> userModels)
        {
            await using var context = new DatabaseContext();
            var itemDictionary = userModels.ToDictionary(x => x.Id);
            var entities = await context.Users.Where(x => itemDictionary.Keys.ToList().Contains(x.Id)).ToListAsync();
            foreach (var item in entities)
            {
                if (itemDictionary.TryGetValue(item.Id, out var updatedItem))
                {
                    _mapper.Map(updatedItem, item);
                }
            }
            await context.SaveChangesAsync();

            return _mapper.Map<List<CreateUpdateUserModel>>(entities);
        }

        public async Task<int> DeleteAsync(List<Guid> ids)
        {
            await using var context = new DatabaseContext();
            var users = context.Users.Where(x => ids.Contains(x.Id));
            context.Users.RemoveRange(users);
            return await context.SaveChangesAsync();
        }

        #region Private Methods

        private IQueryable<User> Fetch(IQueryable<User> table)
        {
            return table;
        }

        #endregion
    }
}
