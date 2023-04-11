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
            {typeof(BadCredentialsException), HttpStatusCode.BadRequest},
            {typeof(RestrictedContentException), HttpStatusCode.UnavailableForLegalReasons},
            {typeof(NoContentException), HttpStatusCode.NoContent}
        };
        public static Type[] BadRequestExceptions =
        {
            typeof(BadCredentialsException),
            typeof(NotFoundException),
        };
        public static Type[] NoContentExceptions =
        {
            typeof(NoContentException)
        };
        public static Type[] RestrictedContentExceptions =
        {
            typeof(RestrictedContentException)
        };

        public static HttpStatusCode GetExceptionStatusCode(Exception ex)
        {
            bool exceptionFound = exceptionStatusCodes.TryGetValue(ex.GetType(), out var statusCode);
            return exceptionFound ? statusCode : HttpStatusCode.InternalServerError;
        }
    }
}
