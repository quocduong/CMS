using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.EntityFramework.Domain
{
    public class Menu : BaseEntity
    {
        [MaxLength(512)]
        public string DisplayName { get; set; }
        [MaxLength(512)]
        public string Url { get; set; }
        public int Order { get; set; }
        public Guid? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public Menu Parent { get; set; }
    }
}
