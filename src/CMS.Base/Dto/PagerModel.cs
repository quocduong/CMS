using System;

namespace CMS.Base.Dto
{
    public class PagerModel
    {
        public PagerModel()
        {
            PageIndex = 1;
            PageSize = 25;
            TotalCount = 0;
        }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPage
        {
            get
            {
                return (int)Math.Ceiling((double)TotalCount / PageSize);
            }
        }
    }
}
