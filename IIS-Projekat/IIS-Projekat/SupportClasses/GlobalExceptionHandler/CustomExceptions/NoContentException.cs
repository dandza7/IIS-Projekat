namespace IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class NoContentException : Exception
    {
        public NoContentException(string message = "User does not have saved avatar!") : base(message)
        { }
    }
}
