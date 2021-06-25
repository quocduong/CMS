using CMS.EntityFramework.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMS.EntityFramework.Domain
{
    public class Tag : BaseEntity
    {
        [MaxLength(EntityLength.DefaultLength)]
        public string Name { get; set; }

        [MaxLength(EntityLength.DefaultLength)]
        public string Slug { get; set; }

        public string Description { get; set; }

        [MaxLength(EntityLength.DefaultLength)]
        public string MetaTitle { get; set; }

        [MaxLength(EntityLength.DefaultLength)]
        public string MetaDescription { get; set; }

        [MaxLength(EntityLength.DefaultLength)]
        public string OgTitle { get; set; }

        [MaxLength(EntityLength.DefaultLength)]
        public string OgDescription { get; set; }

        public bool IsNoFollow { get; set; }

        [StringLength(10)]
        public string Language { get; set; }

        public int? TypeId { get; set; }

        public virtual ICollection<NewsTag> NewsTags { get; set; }
        public virtual ICollection<ProductTagMapping> ProductTags { get; set; }
    }
}
