using HomeTask15Web.Service;

namespace HomeTask15Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            2.Добавить в контроллер HttpPost для модифицирования настроек митинг-комнаты
            3.Модифицировать класс сервиса для сохранения экземпляра настроек митинг-комнаты в appSetting.json.
            4.* Добавить возможность получать настройки и сохранять настройки в виде коллекций митинг-комнат, различающиеся по именам.
            5.Использовать форму и  HTML / tag хэлперы для вывода настроек митинг комнаты и сохранения их.
             */
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<ISettingsService,SettingsService>(); 
            
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
