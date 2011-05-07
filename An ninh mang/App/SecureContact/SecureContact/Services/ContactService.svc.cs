using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using System.Security.Permissions;

namespace SecureContact
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ContactService" in code, svc and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class ContactService : IContactService
    {
        private readonly List<Person> personCollection;

        public ContactService()
        {
            personCollection = new List<Person> 
            { 
                new Person { PersonId = 0, FullName = "Nguyễn Hồng Phúc", Age = 30, Address="",EmailAddress="nguyenhongphuc@gmail.com"}, 
                new Person { PersonId = 1, FullName = "Vũ Thành Trung", Age = 35 ,Address="",EmailAddress="trung@gmail.com"}, 
                new Person { PersonId = 2, FullName = "Hoàng Văn Giáp", Age = 28, Address="",EmailAddress="" }, 
                new Person { PersonId = 3, FullName = "Nguyễn Quang Cường", Age = 25, Address="", EmailAddress="" }, 
                new Person { PersonId = 4, FullName =  "Lê Thị Bảo", Age = 31,Address="", EmailAddress="" }, 
            };

        }

        public bool HasPerson(int personId)
        {
            return personCollection.Any(x => x.PersonId == personId);
        }


        public Person GetPerson(int personId)
        {
            if (!this.HasPerson(personId))
            {
                var errorMsg = new CustomFaultMsg("No Employee have ID: " + personId);
                throw new FaultException<CustomFaultMsg>(errorMsg);
            }

            return this.personCollection.FirstOrDefault(x => x.PersonId == personId);
        }

        //[PrincipalPermission(SecurityAction.Demand,Role="Director")]
        public Person[] GetAll()
        {
            return personCollection.ToArray();
        }

        public void AddPerson(Person person)
        {
            this.personCollection.Add(person);
        }

        public void EditPerson(int personId, Person person)
        {
            Person p = this.GetPerson(personId);

            if (p == null)
            {
                var error = new CustomFaultMsg("No Employee have ID: " + personId);
                throw new FaultException<CustomFaultMsg>(error);
            }

            p.FullName = person.FullName;
            p.Age = person.Age;
        }

        public void DeletePerson(int personId)
        {
            Person p = this.GetPerson(personId);
            this.personCollection.Remove(p);
        }
    }
}
