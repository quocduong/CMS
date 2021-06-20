using CMS.Base.Dto;
using CMS.Base.Dto.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.EntityFramework.Repositories.Products
{
    public interface IProductRepository : IRepository
    {
        Task<List<ProductModel>> ReadAsync(FilterModel filter, PagerModel pager = null, SortingOption sorting = null);
        Task<List<CreateOrUpdateProduct>> CreateAsync(List<CreateOrUpdateProduct> listProduct);
        Task<List<CreateOrUpdateProduct>> UpdateAsync(List<CreateOrUpdateProduct> listProductUpdate);
        Task<int> DeleteAsync(List<Guid> listGuid);
    }
}
