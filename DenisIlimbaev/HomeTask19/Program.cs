using HomeTask15Web.CustomMiddleware;
using HomeTask15Web.ExtensionsMiddleware;
using HomeTask15Web.Service;

namespace HomeTask15Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
           Домашнее задание:
           
           Добавить фильтр, который устанавливает время запроса в Header ответа
             */
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSingleton<UseExeptionMiddleWare>();
            builder.Services.AddTransient<ISettingsService,SettingsService>(); 
            builder.Services.AddControllersWithViews();
          
            var app = builder.Build();

            //Добавить в проект предыдущего занятия Middleware для обработки исключений.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseException();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
