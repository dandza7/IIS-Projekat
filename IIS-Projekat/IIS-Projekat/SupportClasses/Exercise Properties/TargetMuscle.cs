using System.Collections.Generic;
using Microsoft.AspNetCore.Html;

namespace IIS_Projekat.SupportClasses.Exercise_Properties
{
    static public class TargetMuscle
    {
        public const string Calves = "Calves";
        public const string Quads = "Quads";
        public const string Hamstrings = "Hamstrings";
        public const string Abductors = "Abductors";
        public const string Adductors = "Adductors";
        public const string Gluteus = "Gluteus";
        public const string Core = "Core";
        public const string Abs = "Abs";
        public const string LowerBack = "Lower Back";
        public const string Lats = "Lats";
        public const string TeresMajor = "Teres Major";
        public const string LowerTraps = "Lower Traps";
        public const string Traps = "Traps";
        public const string RearDelts = "Rear Delts";
        public const string SideDelts = "Side Delts";
        public const string FrontDelts = "Front Delts";
        public const string UpperChest = "Upper Chest";
        public const string LowerChest = "Lower Chest";
        public const string Biceps = "Biceps";
        public const string Brachialis = "Brachialis";
        public const string Triceps = "Triceps";
        public const string Forearms = "Forearms";

        private static readonly HashSet<string> _validTargetMuscles = new HashSet<string> {
            Calves,
            Quads,
            Hamstrings,
            Abductors,
            Adductors,
            Gluteus,
            Core,
            Abs,
            LowerBack,
            Lats,
            TeresMajor,
            LowerTraps,
            Traps,
            RearDelts,
            SideDelts,
            FrontDelts,
            UpperChest,
            LowerChest,
            Biceps,
            Brachialis,
            Triceps,
            Forearms
        };

        public static bool isValidMuscleGroup(string muscleGroup)
        {
            return _validTargetMuscles.Contains(muscleGroup);
        }
    }
}
