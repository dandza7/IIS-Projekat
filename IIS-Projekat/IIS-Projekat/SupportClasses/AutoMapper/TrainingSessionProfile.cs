﻿using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Training.Session;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class TrainingSessionProfile: Profile
    {
        public TrainingSessionProfile()
        {
            CreateMap<TrainingSessionDTO, TrainingSession>();
            CreateMap<TrainingSession, PreviewTrainingSessionDTO>();
        }
    }
}
