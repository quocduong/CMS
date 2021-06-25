using CMS.EntityFramework.Constants;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.EntityFramework.Domain
{
    public class Product : BaseEntity
    {
        public Product()
        {
            ProductTagMappings = new HashSet<ProductTagMapping>();
            ProductProductCategories = new HashSet<ProductProductCategory>();
        }

        [MaxLength(EntityLength.NameLength)]
        public string Name { get; set; }
        [MaxLength(EntityLength.NameLength)]
        public string Slug { get; set; }
        public double? Price { get; set; }
        public decimal? OldPrice { get; set; }
        [MaxLength(EntityLength.ContentLength)]
        public string Description { get; set; }
        public string Content { get; set; }
        [MaxLength(EntityLength.NameLength)]
        public string Thumbnail { get; set; }
        public bool IsSale { get; set; }
        public bool IsNew { get; set; }
        public bool ShowOnHomepage { get; set; }
        public bool IncludeInSiteNavigation { get; set; }
        [StringLength(250)]
        public string MetaKeywords { get; set; }
        public bool AllowComment { get; set; }
        public bool AllowRating { get; set; }

        public virtual ICollection<ProductTagMapping> ProductTagMappings { get; set; }
        public virtual ICollection<ProductProductCategory> ProductProductCategories { get; set; }
    }
}
