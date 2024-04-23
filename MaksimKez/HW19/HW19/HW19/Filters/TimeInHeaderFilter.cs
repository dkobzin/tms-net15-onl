using Microsoft.AspNetCore.Mvc.Filters;

namespace HW19.Filters
{
    public class TimeInHeaderFilter : Attribute, IActionFilter
    {
        private static int counter = 0;
        public void OnActionExecuted(ActionExecutedContext context)
        {
            counter++;
            context.HttpContext.Response.Headers.Append($"Response time num {counter}",
                DateTime.Now.ToString("ss:ff"));
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
