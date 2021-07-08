using System;
using System.Collections.Generic;
using Xunit;
using LexiconAssigment3_TodoItConsoleApp.Model;

namespace LexiconAssigment3_TodoItConsoleApp.Tests
{
    public class TodoTest
    {
        [Fact]
        public void ConstructorNotNull()
        {
            //Arrange
            int id = 1;
            string description = "Work";

            //Act
            Todo todo = new Todo(id, description);

            //Assert
            Assert.NotNull(todo);
        }

        [Fact]
        public void setIdCorrect()
        {
            //Arrange
            int id = 10;
            string description = "Going to dentist.";
            int expected = 10;

            //Act
            Todo todo = new Todo(id, description);

            //Assert
            Assert.Equal(expected, todo.TodoId);
        }

        [Fact]
        public void setDescriptionCorrect()
        {
            //Arrange
            int id = 10;
            string description = "Going to dentist.";
            string expected = "Going to dentist.";

            //Act
            Todo todo = new Todo(id, description);

            //Assert
            Assert.Equal(expected, todo.Description);
        }

        [Fact]
        public void setIdIncorrectThrowException()
        {
            //Arrange
            int id = -7;
            string description = "Going to dentist.";

            //Act
            ArgumentException actual = Assert.Throws< ArgumentException>(()=> new Todo(id, description));

            //Assert
            Assert.Equal("Todo Id must start from 1.", actual.Message);
        }

        [Theory]
        [InlineData(3, "")]
        [InlineData(3, null)]
        [InlineData(3, " ")]
        public void setDescrptionNullThrowException(int id, string description)
        {
            //Act
            ArgumentException actual = Assert.Throws<ArgumentException>(() => new Todo(id, description));

            //Assert
            Assert.Equal("Please fill the description.", actual.Message);
        }
    }
}