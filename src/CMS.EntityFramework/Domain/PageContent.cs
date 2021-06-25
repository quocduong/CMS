using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class PageContent : BaseEntity
    {
        public int? HashCode { get; set; }

        [StringLength(512)]
        public string ImageUrl { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(512)]
        public string Slug { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        [StringLength(512)]
        public string Link { get; set; }

        public int Order { get; set; }

        [StringLength(10)]
        public string Language { get; set; }

        public Guid? PageCategoryId { get; set; }

        [ForeignKey("PageCategoryId")]
        public virtual PageCategory PageCategory { get; set; }
    }
}
