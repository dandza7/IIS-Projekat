namespace IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message = "Not found!") : base(message)
        { }
    }
}
