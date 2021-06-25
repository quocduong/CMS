using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class PageCategory : SeoModel
    {
        public int? HashCode { get; set; }

        [StringLength(512)]
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? PageId { get; set; }

        public Guid? ParentId { get; set; }

        public string Hierarchy { get; set; }

        [StringLength(10)]
        public string Language { get; set; }

        [ForeignKey("ParentId")]
        public virtual PageCategory Parent { get; set; }


        [ForeignKey("PageId")]
        public virtual Page Page { get; set; }

        public virtual ICollection<PageCategory> ChildPageCategories { get; set; }

        public virtual ICollection<PageContent> PageContents { get; set; }
    }
}
