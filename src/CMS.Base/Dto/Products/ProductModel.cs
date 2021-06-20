using CMS.EntityFramework.Domain;
using System;

namespace CMS.Base.Dto.Products
{
    public class ProductModel : BaseModel
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public bool IsSale { get; set; }
        public bool IsNew { get; set; }
        public Guid ProductProductCategoryId { get; set; }
        public virtual ProductProductCategory ProductProductCategory { get; set; }
    }
}
