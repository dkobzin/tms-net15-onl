using DAL;
using DAL.Entities;
using Services.DTO;

namespace Services
{
    public class PersonService
    {
        public PersonService()
        {
            this.context = new ApplicationDbContext();
        }

        protected ApplicationDbContext context { get; private set; }
        public PersonDto GetPerson(Guid id)
        {
            var person = context.GetPerson(id);
            return new PersonDto
            {
                Id = person.Id,
                Name = person.Name
            };
        }

        public void SavePerson(PersonDto model)
        {
            var person = new Person();
            context.SavePost(person);
        }
    }
}
