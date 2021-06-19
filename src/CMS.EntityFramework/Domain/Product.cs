using CMS.EntityFramework.Constants;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class Product : BaseEntity
    {
        [MaxLength(EntityLength.NameLength)]
        public string Name { get; set; }
        [MaxLength(EntityLength.NameLength)]
        public string Slug { get; set; }
        public double? Price { get; set; }
        [MaxLength(EntityLength.ContentLength)]
        public string Description { get; set; }
        public string Content { get; set; }
        [MaxLength(EntityLength.NameLength)]
        public string Thumbnail { get; set; }
        public bool IsSale { get; set; }
        public bool IsNew { get; set; }
        public Guid ProductProductCategoryId { get; set; }
        [ForeignKey("ProductProductCategoryId")]
        public virtual ProductProductCategory ProductProductCategory { get; set; }
    }
}
