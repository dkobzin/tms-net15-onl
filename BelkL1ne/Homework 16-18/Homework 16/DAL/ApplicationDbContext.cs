using System;
using System.ComponentModel;
using System.Text.Json;
using Homework_16.DAL.Entities;
using Homework_16.Servicees.DTO;

namespace Homework_16.DAL
{
    public class ApplicationDbContext
    {
        public MeetingRoom GetMeetingRoom(Guid id)
        {
            return new MeetingRoom()
                {
                    Id = id,
                    Name = "Test Person",
                    MaxPeople = 10,
                    Duration = TimeSpan.FromHours(1) + TimeSpan.FromMinutes(30)
                };
        }

        public async void SaveMeetingRoom(MeetingRoom model)
        {
            using (FileStream fs = new FileStream("MeetingRoomSettings.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<MeetingRoom>(fs, model);
            }
        }
    }
}
