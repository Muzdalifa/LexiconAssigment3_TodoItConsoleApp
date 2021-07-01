using System;
using Xunit;
using LexiconAssigment3_TodoItConsoleApp.Model;

namespace LexiconAssigment3_TodoItConsoleApp.Tests
{
    public class PersonTest
    {
        [Fact]
        public void SetFistNameWorkCorrect()
        {
            //Arrange
            int id = 1;
            string fistName = "Maida";
            string lastName = "Ali";
            string expected = "Maida";

            //act
            Person person1 = new Person(id, fistName, lastName);
            string actual = person1.FirstName;

            //Assert
            Assert.Equal(expected, actual);
        }

        /*see if firstName parameter really set first name and not lastname,
        ie not to rearrange the field*/ 
        [Fact]
        public void SetFistNameWorInkCorrect() 
        {
            //Arrange
            int id = 2;
            string fistName = "Ali";
            string lastName = "Maida";
            string expected = "Maida";

            //act
            Person person1 = new Person(id, fistName, lastName);
            string actual = person1.FirstName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetLastNameWorkCorrect()
        {
            //Arrange
            int id = 3;
            string fistName = "Maida";
            string lastName = "Ali";
            string expected = "Ali";

            //act
            Person person1 = new Person(id, fistName, lastName);
            string actual = person1.LastName;

            //Assert
            Assert.Equal(expected, actual);
        }

        /*see if lastName parameter really set last name and not firstName,
        ie not to rearrange the names*/
        [Fact]
        public void SetLastNameWorInkCorrect()
        {
            //Arrange
            int id = 4;
            string fistName = "Ali";
            string lastName = "Maida";
            string expected = "Ali";

            //act
            Person person1 = new Person(id, fistName, lastName);
            string actual = person1.LastName;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PersonIdWorkCorrect()
        {
            //Act
            Person person1 = new Person(1,"Ana", "Mikael");
            Person person2 = new Person(2,"Sune", "Andersso");

            //ssert
            Assert.True(person1.PersonId < person2.PersonId);
        }

        [Fact]
        public void PrintInfoContainsCorrectInfo()
        {
            //Arrange
            int id = 1;
            string fistName = "Maida";
            string lastName = "Ali";

            //act
            Person person1 = new Person(id,fistName, lastName);
            string actual = person1.PrintInfo();

            //Assert
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
            //Arrange
            int id = 1;
            string firstName = "Maida";
            string lastName = "Ali"; 

            //Act 
            Person person1 = new Person(id, firstName, lastName);

            //Asert
            Assert.NotNull(person1);
        }
    }
}
