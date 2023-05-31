﻿using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class MuscleGroup : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public ICollection<ExerciseMuscleGroup> Exercises { get; set; } = new List<ExerciseMuscleGroup>();
        public ICollection<InjuredMuscleTherapy> Therapies { get; set; } = new List<InjuredMuscleTherapy>();
    }
}
