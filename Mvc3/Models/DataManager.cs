using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc3.Models
{
    public static class DataManager
    {
        static List<Person> personList = new List<Person>();

        public static void AddPerson(Person person)
        {
            person.Id = ++Person.idCounter;
            personList.Add(person);
        }

        public static PeopleIndexVM[] GetAllPeople()
        {
            return personList
                .Select(c => new PeopleIndexVM
                {
                    Name = c.Name,
                    Email = c.Email,
                    Id = c.Id,
                    ShowAsHighLighted = c.Email.EndsWith("acme.com")
                })
                .ToArray();
        }

        public static Person GetOnePerson(int id)
        {
            return personList
                .SingleOrDefault(c => c.Id == id);
        }

        public static void UpdatePerson(Person updatedPersonInfo, int id)
        {
            Person personToUpdate = GetOnePerson(id);
            personToUpdate.Name = updatedPersonInfo.Name;
            personToUpdate.Email = updatedPersonInfo.Email;
        }
     
    }
}
