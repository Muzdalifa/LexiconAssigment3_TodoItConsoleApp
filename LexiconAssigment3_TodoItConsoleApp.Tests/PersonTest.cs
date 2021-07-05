using System;
using Xunit;
using LexiconAssigment3_TodoItConsoleApp.Model;

namespace LexiconAssigment3_TodoItConsoleApp.Tests
{
    public class PersonTest
    {
        private readonly Person _person;
        public PersonTest()
        {
            _person = new Person(1,"Maida","Ali");
        }
        [Fact]
        public void SetFistNameWorkCorrect()
        {
            //Arrange
            string expected = "Maida";

            ////act
            string actual = _person.FirstName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetLastNameWorkCorrect()
        {
            //Arrange
            string expected = "Ali";

            //act
            string actual = _person.LastName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PersonIdWorkCorrect()
        {
            //Act
            Person person2 = new Person(2,"Sune", "Andersso");

            //ssert
            Assert.True(_person.PersonId < person2.PersonId);
        }

        [Fact]
        public void PrintInfoContainsCorrectInfo()
        {
            //Arrange
            int id = 1;
            string fistName = "Maida";
            string lastName = "Ali";

            //act
            string actual = _person.PrintInfo();

            //Assert
            Assert.Contains(id.ToString(), actual);
            Assert.Contains(fistName, actual);
            Assert.Contains(lastName, actual);
        }

        [Theory]
        [InlineData(1,null,"Ali")]
        [InlineData(2, "", "Ali")]
        [InlineData(3, "", "")]
        public void SetIncorrectModelInputThrowException(int id, string firstName, string lastName)
        {            
            //act
            ArgumentException actual = Assert.Throws<ArgumentException>(()=> new Person(id,firstName, lastName));

            //Assert
            Assert.Equal("First name cannot be empty.", actual.Message);
        }

        [Fact]
        public void SetEmptyLastNameThrowException()
        {
            //Arrange
            int id = 1;
            string fistName = "Maria";
            string lastName = "";

            //act
            ArgumentException actual = Assert.Throws<ArgumentException>(()=> new Person(id, fistName, lastName));

            //Assert
            Assert.Equal("Last name cannot be empty.", actual.Message);
        }

        [Fact]
        public void ConstructorContainsNotNullInfo()
        {
            //Asert
            Assert.NotNull(_person);
        }
    }
}
