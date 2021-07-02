using AutoMapper;
using CMS.Base.Dto.PageCategories;
using CMS.Base.Dto.Pages;
using CMS.Base.Dto.PageTag;
using CMS.Base.Dto.Tags;
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

            CreateMap<PageCategory, PageCategoryViewModel>();
            CreateMap<PageCategoryViewModel, PageCategory>();

            CreateMap<Page, PageViewModel>()
                .ForMember(m => m.PageCategories, opt => opt.MapFrom(m => m.PageCategories))
                .ForMember(m => m.PageTags, opt => opt.MapFrom(m => m.PageTags));
            CreateMap<CreateUpdatePageModel, Page>();

            CreateMap<PageTag, PageTagViewModel>();

            CreateMap<Tag, TagViewModel>();
        }
    }
}
