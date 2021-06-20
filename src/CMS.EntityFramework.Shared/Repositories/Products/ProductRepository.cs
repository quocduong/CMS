using AutoMapper;
using CMS.Base.Dto;
using CMS.Base.Dto.Products;
using CMS.EntityFramework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.EntityFramework.Repositories.Products
{
    public class ProductRepository : Repository, IProductRepository
    {
        private readonly IMapper _mapper;
        public ProductRepository (IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<List<CreateOrUpdateProduct>> CreateAsync(List<CreateOrUpdateProduct> listProduct)
        {
            await using var dbContext = new DatabaseContext();
            var entitis = _mapper.Map<List<Product>>(listProduct);
            dbContext.Products.AddRange(entitis);
            return _mapper.Map<List<CreateOrUpdateProduct>>(listProduct);
        }

        public async Task<int> DeleteAsync(List<Guid> listGuid)
        {
            await using var dbContext = new DatabaseContext();
            var items = dbContext.Products.Where(x => listGuid.Contains(x.Id));
            dbContext.Products.RemoveRange(items);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<List<Base.Dto.Products.ProductModel>> ReadAsync(FilterModel filter, PagerModel pager = null, SortingOption sorting = null)
        {
            await using var dbContext = new DatabaseContext();
            IQueryable<Product> table = dbContext.Products;
            if (!string.IsNullOrEmpty(filter.Keyword))
            {
                string keyWord = filter.Keyword.ToUpper();
                table = table.Where(x => x.Name.ToUpper().Contains(keyWord));
            }
            //if (!string.IsNullOrEmpty(sorting.SortBy))
            //{
            //    var props = table.GetType().GetProperties();
            //    foreach (var prop in props)
            //    {
            //        if (prop.ToString() == sorting.SortBy.ToString())
            //        {
            //        }
            //    }
            //    if (prop != null)
            //        table.OrderBy(x=>x.Id).
            //    //if (sorting.SortingDirection == SortingDirection.Desc)
            //    //{
            //    //    table.OrderByDescending()
            //    //}
            //}
            return _mapper.Map<List<Base.Dto.Products.ProductModel>>(table.ToListAsync());
        }

        public async Task<List<CreateOrUpdateProduct>> UpdateAsync(List<CreateOrUpdateProduct> listProductUpdate)
        {
            await using var dbContext = new DatabaseContext();
            var itemDictionary = listProductUpdate.ToDictionary(x => x.Id);
            var entities = await dbContext.Products.Where(x => itemDictionary.Keys.ToList().Contains(x.Id)).ToListAsync();
            foreach (var item in entities)
            {
                if (itemDictionary.TryGetValue(item.Id, out var updatedItem))
                {
                    _mapper.Map(updatedItem, item);
                }
            }
            await dbContext.SaveChangesAsync();

            return _mapper.Map<List<CreateOrUpdateProduct>>(entities);
        }
    }
}
