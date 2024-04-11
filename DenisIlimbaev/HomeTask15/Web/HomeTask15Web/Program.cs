namespace HomeTask15Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Домашнее задание:
1. Создать на ASP.NET Core из шаблона MVC, посмотреть как оно работает.
2. Создать класс настроек митинг-комнаты (кол-во человек, максимальное время встречи и т.д). 
3. Создать класс сервиса для получения экземпляра настроек митинг-комнаты и зарегистрировать его.
4. Передать в конструкторе контроллера класс сервиса комнаты и в методе GET вывести эти настройки
             */
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<ISettings,SettingsService>(); 
            
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
