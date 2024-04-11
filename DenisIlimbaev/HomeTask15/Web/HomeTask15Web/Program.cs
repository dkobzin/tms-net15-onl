namespace HomeTask15Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * �������� �������:
1. ������� �� ASP.NET Core �� ������� MVC, ���������� ��� ��� ��������.
2. ������� ����� �������� ������-������� (���-�� �������, ������������ ����� ������� � �.�). 
3. ������� ����� ������� ��� ��������� ���������� �������� ������-������� � ���������������� ���.
4. �������� � ������������ ����������� ����� ������� ������� � � ������ GET ������� ��� ���������
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
