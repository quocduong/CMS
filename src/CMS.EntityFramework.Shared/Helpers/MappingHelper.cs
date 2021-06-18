using AutoMapper;
using CMS.Base.Dto.Users;
using CMS.EntityFramework.Domain;

namespace CMS.EntityFramework.Helpers
{
    public class MappingHelper : Profile
    {
        public MappingHelper()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<CreateUpdateUserModel, User>();
        }
    }
}
