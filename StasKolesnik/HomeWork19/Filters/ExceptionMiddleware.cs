namespace HomeWork_16.Filters
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate _next)
        {
            try
            {
                await Console.Out.WriteLineAsync("Обработана ошибка");
                await _next(context);

            }
            catch (InvalidOperationException)
            {
                context.Response.Redirect("Error");
            }
        }
    }
}