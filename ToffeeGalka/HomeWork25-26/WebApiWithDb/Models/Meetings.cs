namespace WebApiWithDb.Models
{
    public class Meetings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public int IdRoom { get; set; }
    }
}
