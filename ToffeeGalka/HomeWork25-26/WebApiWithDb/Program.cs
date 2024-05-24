using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using WebApiWithDb.Services;

namespace WebApiWithDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddTransient<IMeetingRoomService, MeetingRoomService>();
            builder.Services.AddTransient<IUserService, UserService>();
        
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

        }
    }
}
