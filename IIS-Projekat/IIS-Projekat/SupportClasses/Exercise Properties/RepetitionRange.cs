namespace IIS_Projekat.SupportClasses.Exercise_Properties
{
    static public class RepetitionRange
    {
        public const string Low = "5-8";
        public const string Average = "8-12";
        public const string High = "12-15";
        public const string VeryHigh = "12-20";

        static public bool IsRepetitionRangeValid(string range)
        {
            switch (range)
            {
                case Low:
                    return true;
                case Average:
                    return true;
                case High:
                    return true;
                case VeryHigh:
                    return true;
                default:
                    return false;
            }
        }
    }
}
