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
            p1.Clear();

            //Act
            p1.AddPerson( "Muzda", "Ali");

            //Assert
            Assert.NotEmpty(People.Persons);
            Assert.True(People.Persons.Length == 1);
        }

        [Fact]
        public void ArraySizeWorkCorrectly()
        {
            //Arrange
            People p1 = new People();
            p1.Clear();

            p1.AddPerson("Muzda", "Ali");
            p1.AddPerson("Selma", "Hamza");
            p1.AddPerson("Ana", "Peter");

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

            p1.AddPerson("Muzda", "Ali");
            p1.AddPerson("Selma", "Hamza");
            p1.AddPerson("Ana", "Peter");
            Person expeted = new Person(1,"Muzda", "Ali");

            //Act
            Person person1 = p1.FindById(1);

            //Assert
            Assert.Equal(expeted.FirstName, person1.FirstName);
            Assert.Equal(expeted.LastName, person1.LastName);
            Assert.Equal(expeted.PersonId, person1.PersonId);

            Assert.Equal(expeted.PrintInfo(), person1.PrintInfo());
        }

        [Fact]
        public void FindByIDReturnNullIfIdNotfound()
        {
            //Arrange
            People p1 = new People();

            p1.AddPerson("Muzda", "Ali");
            p1.AddPerson("Selma", "Hamza");
            p1.AddPerson("Ana", "Peter");

            //Act
            Person person1 = p1.FindById(31);

            //Assert
            Assert.Null(person1);
        }

        [Fact]
        public void FindAllWorkCorrectly()
        {
            //Arrange
            People p1 = new People();
            Person[] firstPerson = p1.AddPerson("Muzda", "Ali");
            Person[] secondPerson = p1.AddPerson("Selma", "Hamza");
            Person[] thirdPerson = p1.AddPerson("Ana", "Peter");
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
            p1.AddPerson("Muzda", "Ali");
            p1.AddPerson("Selma", "Hamza");
            p1.AddPerson("Ana", "Peter");

            //Act
            p1.Clear();

            //Assert
            Assert.Empty(People.Persons);
            Assert.True(People.Persons.Length == 0);

            //Arrange
            //Add the second time to test
            p1.AddPerson("Martin", "Saidi");
            p1.AddPerson("sheila", "Otiano");

            //Assert
            Assert.NotEmpty(People.Persons);
            Assert.True(People.Persons.Length == 2);

            //Act
            p1.Clear();

            Assert.Empty(People.Persons);
            Assert.True(People.Persons.Length == 0);

            //Arrange
            //Add the second time to test
            p1.AddPerson("Mahmud", "Hamza");
            p1.AddPerson("Clerck", "Marcus");

            //Assert
            Assert.NotEmpty(People.Persons);
            Assert.True(People.Persons.Length == 2);

            //Act
            p1.Clear();

            //Assert
            Assert.Empty(People.Persons);
            Assert.True(People.Persons.Length == 0);
        }

        //[Fact]
        //public void RemovePersonWorkCorrectly()
        //{
        //    //Arrange
        //    People p1 = new People();
        //    int id = 2;
        //    Person removedPerson = new Person(2, "Selma", "Hamza");

        //    Person expected1 = new Person(1, "Muzda", "Ali");
        //    Person expected2 = new Person(3, "Ana", "Peter");

        //    p1.AddPerson("Muzda", "Ali");
        //    p1.AddPerson("Selma", "Hamza");
        //    p1.AddPerson("Ana", "Peter");

        //    //Act
        //    Person[] result = p1.RemoveItemInPersonArray(id);

        //    //Assert
        //    Assert.True(result.Length == 2);

        //    Assert.False(result[1].PersonId == removedPerson.PersonId);
        //    Assert.True(result[0].PersonId == expected1.PersonId);
        //    Assert.True(result[1].PersonId == expected2.PersonId);
        //}
    }
}
