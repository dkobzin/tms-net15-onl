
namespace HW19.Middleware
{
    public class ExceptionHandlerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
			try
			{
				await Console.Out.WriteLineAsync("Error has been caugth");
				await next(context);
			}
			catch (Exception)
			{
				context.Response.Redirect("Privacy");
			}
        }
    }
}
