using CMS.Base.Dto.Pages;
using CMS.Base.Dto.Tags;
using System;

namespace CMS.Base.Dto.PageTag
{
    public class PageTagViewModel
    {
        public Guid PageId { get; set; }
        public virtual PageViewModel Page { get; set; }
        public virtual TagViewModel Tag { get; set; }
    }
}
