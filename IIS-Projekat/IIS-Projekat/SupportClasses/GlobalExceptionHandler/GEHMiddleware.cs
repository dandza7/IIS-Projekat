using System.Net;
using System.Text.Json;

namespace IIS_Projekat.SupportClasses.GlobalExceptionHandler
{
    public class GEHMiddleware
    {
        private readonly RequestDelegate _next;

        public GEHMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                HttpStatusCode httpStatusCode = ExceptionsDictionary.GetExceptionStatusCode(ex);

                context.Response.StatusCode = (int)httpStatusCode;
                if (ExceptionsDictionary.BadRequestExceptions.Contains(ex.GetType()))
                {
                    var exceptionResult = JsonSerializer.Serialize(new { message = ex.Message });
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(exceptionResult);
                    Console.WriteLine("[BAD REQUEST] " + ex.Message);
                }
                else if (ExceptionsDictionary.NoContentExceptions.Contains(ex.GetType()))
                {
                    Console.WriteLine("[NO CONTENT] " + ex.Message);
                }
                else if (ExceptionsDictionary.RestrictedContentExceptions.Contains(ex.GetType()))
                {
                    var exceptionResult = JsonSerializer.Serialize(new { message = ex.Message });
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(exceptionResult);
                    Console.WriteLine("[RESTRICTED CONTENT] " + ex.Message);
                }
                else
                {
                    var exceptionResult = JsonSerializer.Serialize(new { message = ex.Message });
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(exceptionResult);
                    Console.WriteLine("[REQUEST INTERUPTED] " + ex.Message);
                }

            }
        }
    }
}
