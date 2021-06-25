using System;
using System.ComponentModel.DataAnnotations;

namespace CMS.EntityFramework.Domain
{
    public class ProductProductCategory
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductCategoryId { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Product Product { get; set; }
    }
}
