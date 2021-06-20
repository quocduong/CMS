using CMS.Base.Dto;
using CMS.Base.Dto.Products;
using CMS.Business.Interfaces.Products;
using CMS.EntityFramework.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Business.Services.Products
{
    public class ProductService : BaseService, IProductService
    {
        public readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<CreateOrUpdateProduct> CreateOrUpdateProduct(CreateOrUpdateProduct input)
        {
            return input.Id != null
                   ? (await _productRepository.UpdateAsync(new List<CreateOrUpdateProduct> { input })).FirstOrDefault()
                   : (await _productRepository.CreateAsync(new List<CreateOrUpdateProduct> { input })).FirstOrDefault();
        }

        public async Task<int> Delete(List<Guid> guids)
        {
            return (await _productRepository.DeleteAsync(guids));
        }

        public async Task<List<ProductModel>> ReadAsync(FilterModel filter, PagerModel pagerModel = null, SortingOption sortingOption = null)
        {
            return await _productRepository.ReadAsync(filter, pagerModel, sortingOption);
        }
    }
}
