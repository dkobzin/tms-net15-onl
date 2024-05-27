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
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.AspNetCore.Http.HttpResults;

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

            app.Map("/", [Authorize] () =>
            {
              return Results.Redirect("/swagger/index.html");
            });
            // получение всех пользователей
            app.MapGet("/MettingRoomOperation", async (HttpContext context, AppDbContexts data, UserManager<Person> usersManager) =>
            {
                var meetingRoom = new MeetingRoomModel()
                {
                    General = new Person() { UserName = context.User.Identity!.Name, IsSharing = true },
                };
                foreach(var user in data.Members)
                {
                    var obj = await usersManager.FindByEmailAsync(user.Email);
                    if (obj != null) meetingRoom.MembersMeetingRoom!.Add(new Person() { IsSharing = false});
                }
                return meetingRoom;
            }).WithOpenApi();
            app.MapPost("/MeetingRoomOperation/{email}", async(HttpContext context, AppDbContexts data, UserManager <Person> usersManager, string email) =>
            {
                var obj = await usersManager.FindByEmailAsync(email);
                if(obj != null) 
                { 
                    data.Members.Add(new LoginModel() { Email = email });
                    data.SaveChanges();
                    return Results.Ok();
                }
                return Results.Problem();
            });
           
            app.MapPut("/MeetingRoomOperation/{email}/{userIsSharing:bool}",async (string email, bool userIsSharing, UserManager<Person> usersManager, AppDbContexts data) =>
            {
                var obj = await usersManager.FindByEmailAsync(email);
                if(obj != null)
                {
                    obj.IsSharing = userIsSharing;
                    await usersManager.UpdateAsync(obj);
                    return Results.Ok();
                }
                return Results.Problem();
            });
            app.MapDelete("/MeetingRoomOperation/{email}", (string email, AppDbContexts data) =>
            {
                var obj = (from mem in data.Members where mem.Email == email select mem).SingleOrDefault();
                if (obj != null)
                {
                    data.Members.Remove(obj);
                    data.SaveChanges();
                    return Results.Ok();
                }
                return Results.Problem();
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
