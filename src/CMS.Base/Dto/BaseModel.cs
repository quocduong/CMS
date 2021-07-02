using System;

namespace CMS.Base.Dto
{
    public class BaseModel
    {
        public Guid? Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
