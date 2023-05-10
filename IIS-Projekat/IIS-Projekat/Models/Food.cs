﻿using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class Food : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public ICollection<FoodShare> Participations { get; set; } = new List<FoodShare>();
        public ICollection<NutritionShare> NutritionShares { get; set; } = new List<NutritionShare>();
        public ICollection<Allergy> Allergies { get; set; } = new List<Allergy>();
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
