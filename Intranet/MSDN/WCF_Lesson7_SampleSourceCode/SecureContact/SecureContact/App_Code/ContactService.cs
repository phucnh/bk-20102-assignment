using System.Collections.Generic;
using System.Linq;

public class ContactService : IContactService
{
    private readonly List<Person> personCollection;
    public ContactService()
    {
        this.personCollection = new List<Person>
            {
               new Person { PersonId = 0, FullName = "Trần Văn Anh", Age = 30 },
               new Person { PersonId = 1, FullName = "Lý Đào", Age = 35 },
               new Person { PersonId = 2, FullName = "Hoàng Văn Giáp", Age = 28 },
               new Person { PersonId = 3, FullName = "Nguyễn Quang Cường", Age = 25 },
               new Person { PersonId = 4, FullName = "Lê Thị Bảo", Age = 31 },
            };
    }

    public bool HasPerson(int personId)
    {
        return this.personCollection.Any(x => x.PersonId == personId);
    }

    public Person GetPerson(int personId)
    {
        if (!this.HasPerson(personId))
        {
            return null;
        }

        return this.personCollection.FirstOrDefault(x => x.PersonId == personId);
    }

    public void AddPerson(Person person)
    {
        this.personCollection.Add(person);
    }

    public Person[] GetAll()
    {
        return this.personCollection.ToArray();
    }

    public void EditPerson(int personId, Person person)
    {
        Person p = this.GetPerson(personId);
        p.FullName = person.FullName;
        p.Age = person.Age;
    }

    public void DeletePerson(int personId)
    {
        Person p = this.GetPerson(personId);
        this.personCollection.Remove(p);
    }
}

