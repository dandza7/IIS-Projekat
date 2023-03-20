namespace IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class RestrictedContentException : Exception
    {
        public RestrictedContentException(string message = "Restricted content!") : base(message)
        { }
    }
}
