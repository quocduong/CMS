using CMS.EntityFramework.Constants;
using CMS.Shared.Enums.News;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class News : SeoModel
    {
        public News()
        {
            NewsTags = new HashSet<NewsTag>();
        }

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
        public NewsType NewsType { get; set; }

        public int Order { get; set; }
        public Guid NewsNewsCategoryId { get; set; }
        [ForeignKey("NewsNewsCategoryId")]
        public virtual NewsNewsCategory NewsNewsCategory { get; set; }

        [StringLength(10)]
        public string Language { get; set; }

        public virtual ICollection<NewsTag> NewsTags { get; set; }
    }
}
