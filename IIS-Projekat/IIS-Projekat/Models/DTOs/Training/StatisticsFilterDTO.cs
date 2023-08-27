namespace IIS_Projekat.Models.DTOs.Training
{
    public class StatisticsFilterDTO
    {
        public string TimePeriod { get; set; }
        public bool WantsWeight { get; set; }
        public bool WantsBicep { get; set; }
        public bool WantsForearm { get; set; }
        public bool WantsChest { get; set; }
        public bool WantsWaist { get; set; }
        public bool WantsThigh { get; set; }
        public bool WantsCalf { get; set; }
        public string ExerciseName { get; set; }
    }
}
