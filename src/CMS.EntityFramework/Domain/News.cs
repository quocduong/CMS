using CMS.EntityFramework.Constants;
using CMS.Shared.Enums.News;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class News : BaseEntity
    {
        [MaxLength(EntityLength.NameLength)]
        public string Title { get; set; }
        [MaxLength(EntityLength.NameLength)]
        public string Slug { get; set; }
        [MaxLength(EntityLength.ContentLength)]
        public string Description { get; set; }
        public string Content { get; set; }
        [MaxLength(EntityLength.NameLength)]
        public string Thumbnail { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public NewsEnums Status { get; set; }
        public int Order { get; set; }
        public Guid NewsNewsCategoryId { get; set; }
        [ForeignKey("NewsNewsCategoryId")]
        public virtual NewsNewsCategory NewsNewsCategory { get; set; }
    }
}
