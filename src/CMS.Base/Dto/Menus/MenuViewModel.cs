using System;

namespace CMS.Base.Dto.Menus
{
    public class CreateMenu
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
        public Guid ParentId { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
