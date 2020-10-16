using System;

namespace Person.Domain
{
    public class Person
    {
        public int Age { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public IdInfo IdInfo { get; private set; }

        public Person(int age, DateTime birthDate, string name, string lastName, IdInfo idInfo)
        {
            Age = age;
            BirthDate = birthDate;
            Name = name;
            LastName = lastName;
            IdInfo = idInfo;
        }

        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person) MemberwiseClone();
            clone.IdInfo  = new IdInfo(clone.IdInfo.IdNumber);
            clone.Name = new String(Name);
            return clone;
        }
    }
}
