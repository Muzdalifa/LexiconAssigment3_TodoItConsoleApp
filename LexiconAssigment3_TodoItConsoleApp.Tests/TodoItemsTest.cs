using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LexiconAssigment3_TodoItConsoleApp.Data;
using LexiconAssigment3_TodoItConsoleApp.Model;

namespace LexiconAssigment3_TodoItConsoleApp.Tests
{
    public class TodoItemsTest
    {
        [Fact]
        public void AddTodoWorkCorrectly()
        {
            //Arrange
            TodoItems items = new TodoItems();

            //Act
            items.AddTodo(new Todo(1, "cooking food"));

            //Assert
            Assert.NotEmpty(TodoItems.Todo);
        }

        //public static IEnumerable<object []> GetTodoArray()
        //{
        //    yield return new object[] { new Todo(1, "Going supermarket") };
        //    yield return new object[] { new Todo(2, "Doing assignment")};
        //    yield return new object[] { new Todo(3, "Greet friends") };
        //}

        [Fact]
        public void ArraySizeWorkCorrectly()
        {
            //Arrange
            TodoItems todoItems = new TodoItems();

            todoItems.AddTodo(new Todo(1, "Going supermarket"));
            todoItems.AddTodo(new Todo(2, "Doing assignment"));
            todoItems.AddTodo(new Todo(3, "Greet friends"));

            //Act
            int lengthOFArray = todoItems.Size();
            //Assert
            Assert.Equal(3, lengthOFArray);
        }

        ////Test data 
        //public static IEnumerable<object[]> TodoTestData
        //=>new[]{
        //   new Todo[]{new Todo(1, "Going supermarket")} ,
        //   new Todo[]{new Todo(2, "Doing assignment") },
        //   new Todo[]{new Todo(3, "Greet friends")}
        //};

        //[Theory]
        //[MemberData(nameof(TodoTestData))]
        [Fact]
    public void FindTodoByIDWorkCorrectly()
    {
        //Arrange
        TodoItems todoItems = new TodoItems();
        todoItems.AddTodo(new Todo(1, "Going supermarket"));
        todoItems.AddTodo(new Todo(2, "Doing assignment"));
        todoItems.AddTodo(new Todo(3, "Greet friends"));      
        Todo expeted = new Todo(2, "Doing assignment");

        //Act
        Todo specificTodo = todoItems.FindById(2);


        //Assert
        Assert.Equal(expeted.TodoId, specificTodo.TodoId);
        Assert.Equal(expeted.Description, specificTodo.Description);
        Assert.Equal(expeted.PrintInfo(), specificTodo.PrintInfo());
    }

        [Fact]
        public void FindAllTodoWorkCorrectly()
        {
            //Arrange
            TodoItems todoItems = new TodoItems();
            Todo[] todo1 = todoItems.AddTodo(new Todo(1, "Going supermarket"));
            Todo[] todo2 = todoItems.AddTodo(new Todo(2, "Doing assignment"));
            Todo[] todo3 = todoItems.AddTodo(new Todo(3, "Greet friends"));
            int expectedLength = 3;

            //Act
            Todo[] result = todoItems.FindAll();
            //Assert
            Assert.Equal(expectedLength, result.Length);
            Assert.Contains<Todo>(todo1[0],result);
            Assert.Contains<Todo>(todo1[0], result);
            Assert.Contains<Todo>(todo1[0], result);
        }

        [Fact]
        public void ClearWorkCorrectly()
        {
            //Arrange
            TodoItems todoItems = new TodoItems();
            Todo[] todo1 = todoItems.AddTodo(new Todo(1, "Going supermarket"));
            Todo[] todo2 = todoItems.AddTodo(new Todo(2, "Doing assignment"));
            Todo[] todo3 = todoItems.AddTodo(new Todo(3, "Greet friends"));

            //Act
            todoItems.Clear();

            //Assert
            Assert.Empty(TodoItems.Todo);
            Assert.True(TodoItems.Todo.Length == 0);
        }

        [Fact]
        public void ClearEmptyArrayReturnZero()
        {
            //Arrange
            TodoItems todoItems = new TodoItems();

            //Act
            todoItems.Clear();

            //Assert
            Assert.Empty(TodoItems.Todo);
            Assert.True(TodoItems.Todo.Length == 0);
        }
    }
}
