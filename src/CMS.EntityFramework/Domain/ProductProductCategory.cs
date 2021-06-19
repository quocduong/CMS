using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.EntityFramework.Domain
{
    public class ProductProductCategory
    {
        public ProductProductCategory()
        {
            ProductCategories = new HashSet<ProductCategory>();
            Products = new HashSet<Product>();
        }

        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductCategoryId { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
