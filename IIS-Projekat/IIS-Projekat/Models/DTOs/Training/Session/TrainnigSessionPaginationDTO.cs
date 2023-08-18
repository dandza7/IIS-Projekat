using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Models.DTOs.Training.Session
{
    public class TrainnigSessionPaginationDTO
    {
        public string Name { get; set; }
        public PaginationQuery PaginationQuery { get; set; }
    }
}
