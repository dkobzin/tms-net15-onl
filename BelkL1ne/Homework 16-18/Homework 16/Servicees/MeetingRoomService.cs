using Homework_16.DAL;
using Homework_16.DAL.Entities;
using Homework_16.Servicees.DTO;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.Extensions.Configuration;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Configuration;


namespace Homework_16.Servicees
{
    public class MeetingRoomService : IMeetingRoomService
    {
        private readonly IConfiguration configuration;
        public MeetingRoomService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public MeetingRoomDTO GetMeetingRoom(Guid id)
        {
            return new MeetingRoomDTO
            {
                Id = id,
                Name = configuration.GetValue<string>("Name"),
                MaxPeople = configuration.GetValue<int>("MaxPeople"),
                Duration = configuration.GetValue<TimeSpan>("Duration"),
            };
        }

        public void SaveMeetingRoomService(MeetingRoomDTO model) 
        {
            configuration["Name"] = model.Name.ToString();
            configuration["MaxPeople"] = model.MaxPeople.ToString();
            configuration["Duration"] = model.Duration.ToString();

            //var saveMeetengRoom = new MeetingRoom
            //{ 
            //    Id = model.Id,
            //    Name = model.Name,
            //    Duration = model.Duration,
            //    MaxPeople = model.MaxPeople
            //};

            //applicationDbContext.SaveMeetingRoom(saveMeetengRoom);
        }
    }
}
