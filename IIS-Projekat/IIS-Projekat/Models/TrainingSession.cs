﻿using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class TrainingSession : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int NumberOfExercises { get; set; }
        public TrainingPlan TrainingPlan { get; set; }
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}