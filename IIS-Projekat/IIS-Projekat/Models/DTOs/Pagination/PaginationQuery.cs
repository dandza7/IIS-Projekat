namespace IIS_Projekat.Models.DTOs.Pagination
{
    public class PaginationQuery
    {
        /// <example>0</example>
        public int PageSize { get; set; } = 0;
        /// <example>0</example>
        public int Page { get; set; } = 0;
        public List<Order>? Order { get; set; } = new List<Order>();
        public List<Filter>? Filters { get; set; } = new List<Filter>();
    }
}
