namespace IIS_Projekat.Models.DTOs.Pagination
{
    public class PaginationWrapper<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int TotalCount { get; set; }
        public PaginationWrapper(List<T> items, int totalCount)
        {
            Items = items;
            TotalCount = totalCount;
        }
    }
}
