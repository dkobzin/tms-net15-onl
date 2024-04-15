using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace MeetingRoomSettingsApp.Filters
{
    public class AddResponseTimeHeaderFilter : IActionFilter
    {
        private Stopwatch _stopwatch;
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();
            var responseTime = _stopwatch.ElapsedMilliseconds;
            context.HttpContext.Response.Headers.Add("X-Response-Time", responseTime.ToString());
        }
    }
}