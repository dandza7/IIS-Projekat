namespace IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class DuplicateItemException : Exception
    {
        public DuplicateItemException(string message = "This item already exists in database.") : base(message) { }
    }
}
