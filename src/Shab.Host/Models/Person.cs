namespace Shab.Host.Models
{
    public class Person
    {
        public PersonName Name { get; }
        public DateOfBirth DateOfBirth{ get; }

        public Person(PersonName name, DateOfBirth dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
    }
}