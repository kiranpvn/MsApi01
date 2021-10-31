using System.Collections.Generic;

namespace MvcProject01.Models
{
    public class PersonBO
    {
        public List<PersonModel> people{ get; set; }
        public PersonBO()
        {
            this.people = new List<PersonModel> { 
                new PersonModel{Id=1001,PName="Srivatsav",Gender="Male",Age=25},
                new PersonModel{Id=1002,PName="Arun",Gender="Male",Age=28},
                new PersonModel{Id=1003,PName="Gaurangi",Gender="Female",Age=20},
                new PersonModel{Id=1004,PName="Shruthi",Gender="Female",Age=21},
                new PersonModel{Id=1005,PName="Raja",Gender="Male",Age=29}
            };
            //Note: In realtime data will be populated from data source like database
        }        
        public List<PersonModel> GetPeople()
        {
            return people;
        }
        public void AddPerson(PersonModel p)
        {
            people.Add(p);
        }
        public void EditPerson(PersonModel p, int id)
        {
            int index = people.FindIndex(x => x.Id == id);
            people[index] = p;
        }
        public void DeletePerson( PersonModel p)
        {
            people.Remove(p);
        }
    }
}
