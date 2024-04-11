
using Microsoft.AspNetCore.Diagnostics;

namespace HomeTask15Web.CustomMiddleware
{
    public class UseExeptionMiddleWare : IMiddleware
    {
        
        private readonly ILogger _logger;
        public UseExeptionMiddleWare(ILogger<Program> logger)
        {
            _logger = logger;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            IExceptionHandlerFeature? exception = context.Features.Get<IExceptionHandlerFeature>();
            try
            {
                if(exception is not null) throw exception.Error;
            }
            catch
            {
               
                string message = $"{exception!.Error.Message} And {exception.Error.StackTrace}";
                Console.ForegroundColor = ConsoleColor.Red;
                _logger.LogInformation(message);
                Console.WriteLine(message);
            }
            context.Response.StatusCode = 500;
            return next.Invoke(context);
        }
    }
}
