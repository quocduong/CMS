using CMS.EntityFramework.Constants;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class NewsCategory : BaseEntity
    {
        [MaxLength(EntityLength.NameLength)]
        public string Name { get; set; }
        [MaxLength(EntityLength.NameLength)]
        public string Slug { get; set; }
        [MaxLength(EntityLength.NameLength)]
        public string Thumbnail { get; set; }
        [MaxLength(EntityLength.ContentLength)]
        public string Description { get; set; }
        public string Content { get; set; }
        public int Order { get; set; }
        public Guid? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual NewsCategory Parent { get; set; }

        public Guid? NewsNewsCategoryId { get; set; }
        [ForeignKey("NewsNewsCategoryId")]
        public virtual NewsNewsCategory NewsNewsCategory { get; set; }
    }
}
