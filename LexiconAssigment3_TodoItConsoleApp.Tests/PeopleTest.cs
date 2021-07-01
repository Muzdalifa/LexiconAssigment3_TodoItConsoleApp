using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LexiconAssigment3_TodoItConsoleApp.Data;
using LexiconAssigment3_TodoItConsoleApp.Model;
using System.Linq;

namespace LexiconAssigment3_TodoItConsoleApp.Tests
{
    public class PeopleTest
    {
        [Fact]
        public void AddPersonWorkCorrectly()
        {
            //Arrange
            People p1 = new People();

            //Act
            p1.AddPerson(new Person(1, "Muzda", "Ali"));

            //Assert
            Assert.NotEmpty(People.Person);
        }

        //public static IEnumerable<People> GetPerson()
        //{
        //    yield return new Person[] { new Person(1, "Muzda", "Ali") };
        //    yield return new People[] { new People(2, "Selma", "Hamza") };
        //    yield return new People[] { new People(3, "Ana", "Peter") };
        //}

        //[Theory]
        //[MemberData(typeof(GetPerson))]
        [Fact]
        public void ArraySizeWorkCorrectly()
        {
            //Arrange
            People p1 = new People();
            //Act
            p1.AddPerson(new Person(1, "Muzda", "Ali"));
            p1.AddPerson(new Person(2, "Selma", "Hamza"));
            p1.AddPerson(new Person(3, "Ana", "Peter"));

            //Act
            int lengthOFArray = p1.Size();
            //Assert
            Assert.Equal(3, lengthOFArray);
        }

        [Fact]
        public void FindByIDWorkCorrectly()
        {
            //Arrange
            People p1 = new People();
            //Act
            p1.AddPerson(new Person(1, "Muzda", "Ali"));
            p1.AddPerson(new Person(2, "Selma", "Hamza"));
            p1.AddPerson(new Person(3, "Ana", "Peter"));
            Person expeted = new Person(1, "Muzda", "Ali");

            //Act
            Person person1 = p1.FindById(1);
            //Assert
            Assert.Equal(expeted.FirstName, person1.FirstName);
            Assert.Equal(expeted.LastName, person1.LastName);
            Assert.Equal(expeted.PersonId, person1.PersonId);

            Assert.Equal(expeted.PrintInfo(), person1.PrintInfo());
        }

        [Fact]
        public void FindAllWorkCorrectly()
        {
            //Arrange
            People p1 = new People();
            //Act
            Person[] firstPerson = p1.AddPerson(new Person(1, "Muzda", "Ali"));
            Person[] secondPerson = p1.AddPerson(new Person(2, "Selma", "Hamza"));
            Person[] thirdPerson = p1.AddPerson(new Person(3, "Ana", "Peter"));
            int expectedLength = 3;

            //Act
            Person[] people = p1.FindAll();
            //Assert
            Assert.Equal(expectedLength, people.Length);
            Assert.Contains<Person>(firstPerson[0], people);
            Assert.Contains<Person>(secondPerson[0], people);
            Assert.Contains<Person>(thirdPerson[0], people);
        }

        [Fact]
        public void ClearWorkCorrectly()
        {
            //Arrange
            People p1 = new People();
            //Act
            p1.AddPerson(new Person(1, "Muzda", "Ali"));
            p1.AddPerson(new Person(2, "Selma", "Hamza"));
            p1.AddPerson(new Person(3, "Ana", "Peter"));

            //Act
            p1.Clear();

            //Assert
            Assert.Empty(People.Person);
            Assert.True(People.Person.Length == 0);
        }
    }
}
