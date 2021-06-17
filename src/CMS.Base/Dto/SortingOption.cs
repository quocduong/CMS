namespace CMS.Base.Dto
{
    public class SortingOption
    {
        public SortingDirection SortingDirection { get; set; }
        public string SortBy { get; set; }
    }
    public enum SortingDirection
    {
        Asc = 0,
        Desc = 1
    }
}
