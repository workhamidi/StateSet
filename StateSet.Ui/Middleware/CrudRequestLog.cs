using StateSet.LogManager;

namespace StateSet.Ui.Middleware
{
    public class CrudRequestLog
    {
        private readonly RequestDelegate _next;
        private readonly ILog _logger;

        public CrudRequestLog(RequestDelegate next, ILog logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Items.Add("RequestId", Guid.NewGuid().ToString());
            
            await _next(context);
        }
    }
}