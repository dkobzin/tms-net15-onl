using HomeTask15Web.Models;
using Microsoft.AspNetCore.Mvc.Filters;
namespace HomeTask15Web.Fillters
{
    public class TimeFillter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
        }
        public void OnResultExecuting(ResultExecutingContext context)
        {
#pragma warning disable ASP0019
            context.HttpContext.Response.Headers.Add("NowTime", DateTime.Now.ToString());
#pragma warning restore
        }
    }
}
