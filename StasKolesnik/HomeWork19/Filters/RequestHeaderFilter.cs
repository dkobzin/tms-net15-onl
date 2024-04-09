namespace HomeWork_16.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;


    public class RequestTimingFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add("TimeResponse", DateTime.Now.ToString());
        }
    }
}
