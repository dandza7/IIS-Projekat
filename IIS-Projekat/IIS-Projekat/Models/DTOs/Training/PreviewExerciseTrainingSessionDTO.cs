﻿namespace IIS_Projekat.Models.DTOs.Training
{
    public class PreviewExerciseTrainingSessionDTO
    {
        public string ExerciseName { get; set; }
        public string RepetitionRange { get; set; }
        public int NumberOfSets { get; set; }
        public bool IsUnhappy { get; set; }
        public string Note { get; set; }
    }
}
