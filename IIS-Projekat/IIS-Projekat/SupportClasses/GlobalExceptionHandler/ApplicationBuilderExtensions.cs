namespace IIS_Projekat.SupportClasses.GlobalExceptionHandler
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder AddGlobalExceptionHandler(this IApplicationBuilder applicationBuilder)
            => applicationBuilder.UseMiddleware<GEHMiddleware>();
    }
}
