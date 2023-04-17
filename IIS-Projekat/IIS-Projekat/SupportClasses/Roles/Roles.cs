namespace IIS_Projekat.SupportClasses.Roles
{
    static public class Roles
    {
        public const string Admin = "ADMIN";
        public const string Customer = "CUSTOMER";
        public const string Trainer = "TRAINER";
        public const string AvailableRoles = $"{Admin}, {Customer}, {Trainer}";

        static public bool IsRoleValid(string roleName)
        {
            switch (roleName)
            {
                case Admin:
                    return true;
                case Customer:
                    return true;
                case Trainer:
                    return true;
                default:
                    return false;
            }
        }
    }
}
