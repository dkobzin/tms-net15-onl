using System;
using System.ComponentModel;
using System.Runtime;
using System.Text.Json;
using System.Xml.Linq;
using Homework_16.DAL.Entities;
using Homework_16.Servicees.DTO;
using Microsoft.Extensions.Configuration;

namespace Homework_16.DAL
{
    public class ApplicationDbContext()
    {
        public MeetingRoom GetMeetingRoom(Guid id)
        {

            return new MeetingRoom()
            {
                Id = id,
                Name = "Meetimg Room",
                MaxPeople = 10,
                Duration = TimeSpan.FromHours(1) + TimeSpan.FromMinutes(10),
            };
        }

        

        public async void SaveMeetingRoom(MeetingRoom model)
        {
            //using (FileStream fs = new FileStream("appsettings.json", FileMode.OpenOrCreate))
            //{
            //    await JsonSerializer.SerializeAsync<MeetingRoom>(fs, model);
            //}
        }
    }
}
