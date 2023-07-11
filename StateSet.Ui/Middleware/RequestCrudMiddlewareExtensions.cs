namespace StateSet.Ui.Middleware
{
    public static class RequestCrudMiddlewareExtensions
    {
        public static IApplicationBuilder UseCrudRequestLog(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CrudRequestLog>();
        }
    }
}
