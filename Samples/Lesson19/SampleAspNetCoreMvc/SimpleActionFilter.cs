using Microsoft.AspNetCore.Mvc.Filters;

namespace SampleAspNetCoreMvc;

public class SimpleActionFilter: Attribute, IActionFilter // IResourceFilter //, IResultFilter, IExceptionFilter, IAuthorizationFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        //context.HttpContext.Response.WriteAsync($"{nameof(OnActionExecuting)}");
        Console.WriteLine($"{context.Controller.ToString()}.{nameof(OnActionExecuting)}");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        //context.HttpContext.Response.WriteAsync($"{nameof(OnActionExecuted)}");
        Console.WriteLine($"{context.Controller.ToString()}.{nameof(OnActionExecuted)}");
    }
}