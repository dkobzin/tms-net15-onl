using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Lesson16_19_MeetingRoomApp.Filters
{
    public class RequestTimeFilter : IActionFilter
    {
        private Stopwatch _stopwatch;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();
            context.HttpContext.Response.Headers.Append("X-Processing-Time-Milliseconds", _stopwatch.ElapsedMilliseconds.ToString());
        }
    }
}