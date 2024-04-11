using HomeTask15Web.CustomMiddleware;

namespace HomeTask15Web.ExtensionsMiddleware
{
    public static class Extension
    {
        public static IApplicationBuilder UseException(this IApplicationBuilder app)
        {
            return app.UseMiddleware<UseExeptionMiddleWare>();
        }
    }
}
