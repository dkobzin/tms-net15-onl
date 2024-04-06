using Homework_16.DAL;
using Homework_16.DAL.Entities;
using Homework_16.Servicees.DTO;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;


namespace Homework_16.Servicees
{
    public class MeetingRoomService : IMeetingRoomService
    {
        protected ApplicationDbContext applicationDbContext {  get; set; }
        public MeetingRoomService() 
        {
            applicationDbContext = new ApplicationDbContext();
        }
        
        public MeetingRoomDTO GetMeetingRoom(Guid id)
        {
            var meetingRoom = applicationDbContext.GetMeetingRoom(id);
            return new MeetingRoomDTO
            {
                Id = meetingRoom.Id,
                Name = meetingRoom.Name,
                MaxPeople = meetingRoom.MaxPeople,
                Duration = meetingRoom.Duration,
            };
        }

        public void SaveMeetingRoomService(MeetingRoomDTO model) 
        {
            var saveMeetengRoom = new MeetingRoom
            { 
                Id = model.Id,
                Name = model.Name,
                Duration = model.Duration,
                MaxPeople = model.MaxPeople
            };

            applicationDbContext.SaveMeetingRoom(saveMeetengRoom);
        }
    }
}
