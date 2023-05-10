﻿using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class MedicalRecord : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long PatientId { get; set; }
        public User Patient { get; set; }
        public ICollection<Injury> Injuries { get; set; } = new List<Injury>();
        public ICollection<Allergy> Allergies { get; set; } = new List<Allergy>();
        public ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();
        public string Anamnesis { get; set; } = string.Empty;
        public int Height { get; set; } = 0;
        public int Weight { get; set; } = 0;
        public string Therapy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
