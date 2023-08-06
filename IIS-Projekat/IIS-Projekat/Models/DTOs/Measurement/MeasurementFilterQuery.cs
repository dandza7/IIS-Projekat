namespace IIS_Projekat.Models.DTOs.Measurement
{
    public class MeasurementFilterQuery
    {
        public string Filter { get; set; } = string.Empty;
        public int PageSize { get; set; }
        public int Page { get; set; }
    }
}
