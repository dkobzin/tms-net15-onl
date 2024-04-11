using DAL.Entities;

namespace DAL
{
    public class ApplicationDbContext
    {
        public Person GetPerson(Guid id)
        {
            return new Person()
            {
                Id = id,
                Name = "Test Person"
            };
        }

        public void SavePost(Person model)
        {
            // Save model
        }
    }
}
