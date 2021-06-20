using CMS.Base.Dto;
using CMS.Base.Dto.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CMS.Business.Interfaces.Products
{
    public interface IProductService : IBaseService
    {
        Task<List<Base.Dto.Products.ProductModel>> ReadAsync(FilterModel filter, PagerModel pagerModel = null, SortingOption sortingOption = null);
        Task<CreateOrUpdateProduct> CreateOrUpdateProduct(CreateOrUpdateProduct input);
        Task<int> Delete(List<Guid> guids);
    }
}
