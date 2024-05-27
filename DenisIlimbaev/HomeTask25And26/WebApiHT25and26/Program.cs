using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using WebApiHT25and26.Model;
using System.Net.WebSockets;
using WebApiHT25and26.Extensions;
using WebApiHT25and26.Model.IdentityModel;
using WebApiHT25and26.DataModel;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace WebApiHT25and26
{
               /*
          Домашнее задание:
1.Создать ASP.NET WebApi приложение для работы с пользователями, митингами и митинг румами. Обязательно регистрация сваггера. 
2.Добавить БД используя подход Code-First БД через миграцию.
3.Добавить CRUD операции на сервис митинг-рума / пользователями, методы контроллера.
             */
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAuthorization();
            builder.Services.AddDbContext<AppDbContexts>(opt => opt.UseSqlServer(builder.Configuration["DbConf"]));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDefaultIdentity<Person>(opt =>
            {
                opt.User.AllowedUserNameCharacters = null;
                opt.SignIn.RequireConfirmedAccount = true;
            }).AddEntityFrameworkStores<AppDbContexts>();
            builder.Services.AddAuthentication();
            builder.Services.ConfigureApplicationCookie(opt =>
            {

                opt.LoginPath = "/Login";
                opt.LogoutPath = "/Logout";
            });
            
            var app = builder.Build();

            app.Map("/", [Authorize] async (HttpContext context) =>
            {
                string htmlResp = $"<h1>Welcome {context.User.Identity!.Name}</h1> <form action=\"/MettingRoomOperation\"> <button type = \"submit\">Начать конфиренцию</button> </form> "
                + "<form action=\"/Logout\"> <button type = \"submit\">Выйти из аккаунта</button> </form> ";


                context.Response.ContentType = "text/html;charset=utf-8";
                await context.Response.WriteAsync(htmlResp);
            });
            app.MapGet("/MettingRoom", async (HttpContext context, AppDbContexts data, UserManager<Person> userManager) =>
            {
                var meetingRoom = new MeetingRoomModel()
                {
                    General = new Person() { UserName = context.User.Identity!.Name },
                };
                foreach(var user in data.Members)
                {
                    var obj = await userManager.FindByEmailAsync(user.Email);
                    if (obj != null) meetingRoom.MembersMeetingRoom!.Add(obj);
                }
                return meetingRoom;
            }).WithOpenApi();
            app.Map("/MettingRoomOperation",async (HttpContext context) =>
            {
                await context.Response.SendHtml("MeetingRoomOperation");
            });
            app.Map("/MettingRoomOperationFromMember/{operation}", (HttpContext context, AppDbContexts data, UserManager<Person> usermanager,string operation) =>
            {
                var newMember = new LoginModel()
                {
                    Email = context.Request.Form["Email"].ToString() ?? string.Empty
                };
                switch (operation)
                {
                    case "Delete": data.Members.Remove(newMember); break;
                    case "Update": data.Members.Update(newMember); break;
                    case "Create": data.Members.Add(newMember); break;
                }
                return Results.Redirect("/MettingRoomOperation");
            });
            app.MapGet("/Login", async (HttpContext context) =>
            {
               await context.Response.SendHtml("Login");
            });
            app.MapPost("/Login", async (HttpContext context) =>
            {

                //var model = new LoginModel() { Email = context.Request.Form["Mail"]!, Password = context.Request.Form["Password"]! };
                bool isLongSave = false;
                var userManager = context.RequestServices.GetService<UserManager<Person>>();
                var signInManager = context.RequestServices.GetService<SignInManager<Person>>();
                foreach (var member in userManager.Users)
                {
                    Debug.WriteLine(member.Email + member.PasswordHash);
                }
                var task = userManager.FindByEmailAsync(context.Request.Form["Mail"]!);
                while (!task.IsCompleted)
                {
                    Thread.Sleep(200);
                }
              
                var person = task.Result;
                if (person == null) return Results.Redirect("/Register");
                await signInManager.SignInAsync(person, isLongSave);
                return Results.Redirect("/");
            });
            app.Map("/Logout", (SignInManager<Person> signInManager) =>
            {
                signInManager.SignOutAsync();
                return Results.Redirect("/Login");
            });
            app.MapGet("/Register", async (HttpContext context) =>
            {
               await context.Response.SendHtml("Registration");
            });
            app.MapPost("/Register", async (HttpContext context) =>
            {
                var userManager = context.RequestServices.GetService<UserManager<Person>>();
                var signInManager = context.RequestServices.GetService<SignInManager<Person>>();
                var model = new RegisterModel() { Email = context.Request.Form["Mail"]!,
                    Password = context.Request.Form["Password"]!,
                    Name = context.Request.Form["Name"]!,
                    LastName = context.Request.Form["LastName"],
                    Telephone = context.Request.Form["Telephone"]!
                };
                bool isLongSave = false;
                var person = (from userX in userManager.Users
                              where userX.Email == model.Email
                              select userX).SingleOrDefault();
                Debug.WriteLine(person);
                if (person != null)
                {
                    return Results.Redirect("/Login");
                }
                var user = new Person()
                {
                    UserName = (model.Name + model.LastName),
                    Email = model.Email,
                    PasswordHash = model.Password,
                    Telephone = model.Telephone
                };
                var task = userManager.CreateAsync(user);
                while (!task.IsCompleted)
                {
                    Thread.Sleep(200);
                }
                if (task.Result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isLongSave);
                }
                else 
                {
                    foreach(var i in task.Result.Errors)
                    {
                        Debug.WriteLine(i.Code + i.Description );
                    }
                }
               
                return Results.Redirect("/");
            });


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.Run();
        }
    }
}
