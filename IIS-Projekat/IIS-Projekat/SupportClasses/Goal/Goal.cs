namespace IIS_Projekat.SupportClasses.Goal
{
    public static class Goal
    {
        const string Bulk = "Bulk";
        const string Cut = "Cut";
        const string Recomp = "Recomp";
        const string Endurance = "Endurance";
        public const string ValidGoals = $"{Bulk}, {Cut}, {Recomp}, {Endurance}.";

        public static bool IsGoalValid(string goal)
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
