namespace IIS_Projekat.Models.DTOs.Supplement
{
    public class UpdateSupplementDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public float Dose { get; set; }
    }
}
