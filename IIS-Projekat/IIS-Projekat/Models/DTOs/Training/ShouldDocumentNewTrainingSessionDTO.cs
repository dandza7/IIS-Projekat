﻿using IIS_Projekat.Models.DTOs.Training.Session;

namespace IIS_Projekat.Models.DTOs.Training
{
    public class ShouldDocumentNewTrainingSessionDTO
    {
        public bool isTodayDocumented { get; set; }
        public bool isMaxSessionsReached { get; set; }
        public PreviewNewTrainingSessionDTO NewTrainingSessionInfo { get; set; }
    }
}
