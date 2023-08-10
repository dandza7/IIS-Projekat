using AutoMapper;
using IIS_Projekat.Models.DTOs.Training.Request;

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

        public static PaginationWrapper<T> WrapItems(IMapper _mapper, PaginationQuery paginationQuery, List<T> items)
        {
            if(paginationQuery.Page < 1) paginationQuery.Page = 1;
            if(paginationQuery.PageSize < 1) paginationQuery.PageSize = items.Count;
            return new PaginationWrapper<T>
            (
                _mapper.Map<List<T>>(items.Skip((paginationQuery.Page - 1) * paginationQuery.PageSize).Take(paginationQuery.PageSize)),
                items.Count
            );
        }
    }
}
