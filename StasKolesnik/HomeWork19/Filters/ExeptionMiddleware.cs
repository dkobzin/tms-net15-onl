namespace HomeWork_16.Filters
{
    public class ExeptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExeptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
                await Console.Out.WriteLineAsync("Обработана ошибка");
            }
            catch (InvalidOperationException)
            {
                context.Response.Redirect("Error");
            }
        }
    }
}