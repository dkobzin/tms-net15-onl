using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SampleAspNetCoreMvc;
using SampleAspNetCoreMvc.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddMvcCore(options =>
{
    options.Filters.Add(typeof(SimpleActionFilter));
});

builder.Services.AddSingleton<TimeMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
/* app.UseWhen(
    context => context.Request.Path == "/time", // если путь запроса "/time"
    appBuilder =>
    {
        // логгируем данные - выводим на консоль приложения
        appBuilder.Use(async (context, next) =>
        {
            var time = DateTime.Now.ToShortTimeString();
            Console.WriteLine($"Time: {time}");
            await next();   // вызываем следующий middleware
        });

        // отправляем ответ
        appBuilder.Run(async context =>
        {
            var time = DateTime.Now.ToShortTimeString();
            await context.Response.WriteAsync($"Time: {time}");
        });
    }); */
app.UseMiddleware<TimeMiddleware>();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Map("/user/{id:int}/{name:alpha}", (int id, string name) => new { Id = id, Name = name });
app.MapGet("/routes", (IEnumerable<EndpointDataSource> endpointSources) =>
    string.Join("\n", endpointSources.SelectMany(source => source.Endpoints)));

app.Run();
/*app.Run(async (context) => 
{
    await context.Response.WriteAsync("Hello Word!");
});*/

