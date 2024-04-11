namespace SampleAspNetCoreMvc;

public class TimeMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (context.Request.Path == "/time")
        {
            var time = DateTime.Now.ToShortTimeString();
            await context.Response.WriteAsync($"Time: {time}");
            await next.Invoke(context);
        }
        else
        {
            await next.Invoke(context);
        }

    }
}