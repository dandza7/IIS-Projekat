﻿using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class Injury : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public MuscleGroup Muscle { get; set; }
        public ICollection<InjuryMedicalRecord> Injuries { get; set; } = new List<InjuryMedicalRecord>();
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
