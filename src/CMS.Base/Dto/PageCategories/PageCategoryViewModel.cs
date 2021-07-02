using CMS.Base.Dto.Pages;
using System;
using System.Collections.Generic;

namespace CMS.Base.Dto.PageCategories
{
    public class PageCategoryViewModel
    {
        public int? HashCode { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? PageId { get; set; }

        public Guid? ParentId { get; set; }

        public string Hierarchy { get; set; }

        public string Language { get; set; }

        public virtual PageCategoryViewModel Parent { get; set; }


        public virtual PageViewModel Page { get; set; }

        public virtual List<PageCategoryViewModel> ChildPageCategories { get; set; }
    }
}
