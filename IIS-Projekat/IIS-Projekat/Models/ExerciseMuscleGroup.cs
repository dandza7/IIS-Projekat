﻿using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class ExerciseMuscleGroup : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Exercise Exercise { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
        public bool IsPrimaryMuscleGroup { get; set; }
    }
}
