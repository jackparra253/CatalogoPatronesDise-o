using System;
using Person.Domain;
using Xunit;

namespace Person.XUnitTestProject
{
    public class PersonUnitTest
    {
        [Fact(DisplayName = "Should Person create new instance")]
        public void Person_Case_1()
        {
            int age = 30;
            var birthDate = new DateTime(1990,05,31);
            var name = "Jack";
            var lastName = "Parra";
            var idNumber = 1016123654;
            IdInfo idInfo = new IdInfo(idNumber);

            var person = new Domain.Person(age, birthDate, name, lastName, idInfo);

            Assert.Equal(age, person.Age);
            Assert.Equal(birthDate, person.BirthDate);
            Assert.Equal(name, person.Name);
            Assert.Equal(lastName, person.LastName);
            Assert.Equal(idNumber, person.IdInfo.IdNumberNumber);
        }

        [Fact(DisplayName = "Should ShallowCopy return copy Person")]
        public void Person_Case_ShallowCopy()
        {

        }
    }
}
