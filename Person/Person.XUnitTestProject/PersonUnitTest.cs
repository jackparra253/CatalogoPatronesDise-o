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

            var jack = new Domain.Person(age, birthDate, name, lastName, idInfo);

            Assert.Equal(age, jack.Age);
            Assert.Equal(birthDate, jack.BirthDate);
            Assert.Equal(name, jack.Name);
            Assert.Equal(lastName, jack.LastName);
            Assert.Equal(idNumber, jack.IdInfo.IdNumber);
        }

        [Fact(DisplayName = "Should ShallowCopy return copy Person")]
        public void Person_Case_ShallowCopy()
        {
            var idNumber = 1016123654;
            var jack = new Domain.Person(30, new DateTime(1990, 05, 31), "Jack", "Parra", new IdInfo(idNumber));

            Domain.Person jack2 = jack.ShallowCopy();

            Assert.Equal(jack.Age, jack2.Age);
            Assert.Equal(jack.BirthDate, jack2.BirthDate);
            Assert.Equal(jack.Name, jack2.Name);
            Assert.Equal(jack.LastName, jack2.LastName);
            Assert.Equal(jack.IdInfo.IdNumber, jack2.IdInfo.IdNumber);
            Assert.True(jack.IdInfo == jack2.IdInfo);
        }

        [Fact(DisplayName = "Should DeepCopy return copy Person")]
        public void Person_Case_DeepCopy()
        {
            var idNumber = 1016123654;
            var jack = new Domain.Person(30, new DateTime(1990, 05, 31), "Jack", "Parra", new IdInfo(idNumber));

            Domain.Person jack2 = jack.DeepCopy();

            Assert.Equal(jack.Age, jack2.Age);
            Assert.Equal(jack.BirthDate, jack2.BirthDate);
            Assert.Equal(jack.Name, jack2.Name);
            Assert.Equal(jack.LastName, jack2.LastName);
            Assert.Equal(jack.IdInfo.IdNumber, jack2.IdInfo.IdNumber);
            Assert.False(jack.IdInfo == jack2.IdInfo);
        }
    }
}
