namespace IIS_Projekat.SupportClasses.TrainingGoal
{
    public static class TrainingGoal
    {
        const string Bulk = "Bulk";
        const string Cut = "Cut";
        const string Recomp = "Recomp";
        const string Endurance = "Endurance";

        public static bool IsTrainingGoalValid(string goal)
        {
            switch(goal)
            {
                case Bulk: return true;
                case Cut: return true;
                case Recomp: return true;
                case Endurance:  return true;
                default: return false;
            }
        }
    }
}
