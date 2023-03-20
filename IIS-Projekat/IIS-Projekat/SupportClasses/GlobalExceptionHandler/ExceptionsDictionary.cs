using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using System.Net;

namespace IIS_Projekat.SupportClasses.GlobalExceptionHandler
{
    public class ExceptionsDictionary
    {
        private static Dictionary<Type, HttpStatusCode> exceptionStatusCodes = new Dictionary<Type, HttpStatusCode>
        {
            {typeof(Exception), HttpStatusCode.InternalServerError},
            {typeof(NotFoundException), HttpStatusCode.NotFound},
            {typeof(BadCredentialsException), HttpStatusCode.BadRequest}
        };
        public static Type[] BadRequestExceptions =
        {
            typeof(BadCredentialsException)
        };
        public static Type[] NoContentExceptions =
        {
            typeof(NotFoundException)
        };

        public static HttpStatusCode GetExceptionStatusCode(Exception ex)
        {
            bool exceptionFound = exceptionStatusCodes.TryGetValue(ex.GetType(), out var statusCode);
            return exceptionFound ? statusCode : HttpStatusCode.InternalServerError;
        }
    }
}
