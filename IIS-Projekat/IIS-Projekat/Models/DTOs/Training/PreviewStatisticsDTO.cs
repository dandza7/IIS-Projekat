namespace IIS_Projekat.Models.DTOs.Training
{
    public class PreviewStatisticsDTO
    {
        public ICollection<StatisticsDTO> WeightStatistics { get; set; }
        public ICollection<StatisticsDTO> BicepStatistics { get; set; }
        public ICollection<StatisticsDTO> ForearmStatistics { get; set; }
        public ICollection<StatisticsDTO> ChestStatistics { get; set; }
        public ICollection<StatisticsDTO> WaistStatistics { get; set; }
        public ICollection<StatisticsDTO> ThighStatistics { get; set; }
        public ICollection<StatisticsDTO> CalfStatistics { get; set; }
        public ICollection<StatisticsDTO> ExerciseStatistics { get; set; }

    }
}
