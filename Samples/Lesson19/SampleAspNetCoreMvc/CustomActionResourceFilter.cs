using Microsoft.AspNetCore.Mvc.Filters;

namespace SampleAspNetCoreMvc;

public class CustomActionResourceFilter(string id, string name) : Attribute, IActionFilter, IResourceFilter
{
    private string Id { get; set; } = id;
    private string Name { get; set; } = name;

    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine($"{nameof(OnActionExecuting)} {id} {name}");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine($"{nameof(OnActionExecuted)} {id} {name}");
    }

    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        context.HttpContext.Response.Headers.Add(nameof(Id), Id);
        context.HttpContext.Response.Headers.Add(nameof(Name), Name);
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        
    }
}