using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LexiconAssigment3_TodoItConsoleApp.Data;
using LexiconAssigment3_TodoItConsoleApp.Model;
using Newtonsoft.Json;

namespace LexiconAssigment3_TodoItConsoleApp.Tests
{
    public class TodoItemsTest
    {
        private readonly TodoItems _todoItems;
        public TodoItemsTest()
        {
            _todoItems = new TodoItems();
        }
        [Fact]
        public void AddTodoWorkCorrectly()
        {
            //Act
            TodoItemsTestData();

            //Assert
            Assert.NotEmpty(TodoItems.Todo);
            Assert.True(TodoItems.Todo.Length == 5);
        }

        [Fact]
        public void ArraySizeWorkCorrectly()
        {
            //Arrange
            TodoItemsTestData();


            //Act
            int lengthOFArray = _todoItems.Size();

            //Assert
            Assert.Equal(5, lengthOFArray);
        }

        [Fact]
        public void FindTodoByIDWorkCorrectly()
        {
            //Arrange
            TodoItemsTestData();
            Todo expeted = new Todo(2, "Doing assignment");

            //Act
            Todo specificTodo = _todoItems.FindById(2);

            //Assert
            Assert.Equal(expeted.TodoId, specificTodo.TodoId);
            Assert.Equal(expeted.Description, specificTodo.Description);
            Assert.Equal(expeted.PrintInfo(), specificTodo.PrintInfo());
        }

        [Fact]
        public void FindAllTodoWorkCorrectly()
        {
            //Arrange
            Todo[] expected =TodoItemsTestData();
            int expectedLength = 5;

            //Act
            Todo[] result = _todoItems.FindAll();

            //Assert
            Assert.Equal(expectedLength, result.Length);
            Assert.Contains<Todo>(expected[0], result);
            Assert.Contains<Todo>(expected[1], result);
            Assert.Contains<Todo>(expected[4], result);
        }

        [Fact]
        public void FindOutOfRangeTodoShouldReturnNull()
        {
            //Act
            Todo result = _todoItems.FindById(6);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ClearTodoWorkCorrectly()
        {
            //Arrange
            TodoItemsTestData();

            //Act
            _todoItems.Clear();

            //Assert
            Assert.Empty(TodoItems.Todo);
            Assert.True(TodoItems.Todo.Length == 0);

            //Arrange
            TodoItemsTestData();

            //Act
            _todoItems.Clear();

            //Assert
            Assert.Empty(TodoItems.Todo);
            Assert.True(TodoItems.Todo.Length == 0);

            //Arrange
            TodoItemsTestData();

            //Act
            _todoItems.Clear();

            //Assert
            Assert.Empty(TodoItems.Todo);
            Assert.True(TodoItems.Todo.Length == 0);
        }

        [Fact]
        public void ClearEmptyArrayReturnZero()
        {
            //Act
            _todoItems.Clear();

            //Assert
            Assert.Empty(TodoItems.Todo);
            Assert.True(TodoItems.Todo.Length == 0);
        }

        [Fact]
        public void FindByDoneStatusTrueWorkCorrectly()
        {
            //Arrange
            TodoItemsTestData();

            Todo specificTodo1 = _todoItems.FindById(1);
            specificTodo1.Done = true;
            Todo specificTodo2 = _todoItems.FindById(2);
            specificTodo2.Done = true;
            Todo specificTodo3 = _todoItems.FindById(3); //by default Done is false


            //Act
            Todo[] result = _todoItems.FindByDoneStatus(true);
            //Assert
            Assert.Contains<Todo>(specificTodo1, result);
            Assert.Contains<Todo>(specificTodo2, result);
            Assert.DoesNotContain<Todo>(specificTodo3, result);
        }

        [Fact]
        public void FindByDoneStatusFalseorWorkCorrectly()
        {
            //Arrange
            TodoItemsTestData();
            Todo specificTodo1 = _todoItems.FindById(1);
            specificTodo1.Done = true;
            Todo specificTodo2 = _todoItems.FindById(2);
            specificTodo2.Done = true;
            Todo specificTodo3 = _todoItems.FindById(3); //by default Done is false

            //Act
            Todo[] result = _todoItems.FindByDoneStatus(false);
            //Assert
            Assert.Contains<Todo>(specificTodo3, result);
            Assert.DoesNotContain<Todo>(specificTodo1, result);
            Assert.DoesNotContain<Todo>(specificTodo2, result);
        }

        [Fact]
        public void FindByAssigneeIDWorkkCorrectly()
        {
            //Arrange
            TodoItemsTestData();

            Todo specificTodo1 = _todoItems.FindById(1);
            specificTodo1.Assignee = new Person(1, "Bellamy", "Donald");
            Todo specificTodo2 = _todoItems.FindById(2);
            specificTodo2.Assignee = new Person(2, "Octavia", "Donald");
            Todo specificTodo3 = _todoItems.FindById(3); //by default Done is false
            specificTodo3.Assignee = new Person(3, "Indra", "Koi");

            //Act
            Todo[] result = _todoItems.FindByAssignee(2);

            //Assert
            Assert.Contains<Todo>(specificTodo2, result);
            Assert.DoesNotContain<Todo>(specificTodo1, result);
        }

        [Fact]
        public void FindByAssigneeObjectCorrectly()
        {
            //Arrange
            TodoItemsTestData();

            Todo specificTodo1 = _todoItems.FindById(1);
            specificTodo1.Assignee = new Person(1, "Bellamy", "Donald"); //ssign person to TodoId = 1;

            Todo specificTodo2 = _todoItems.FindById(2);
            specificTodo2.Assignee = new Person(2, "Octavia", "Donald"); //OCtavia has been assigned in two TodoID,

            Todo specificTodo3 = _todoItems.FindById(3);
            specificTodo3.Assignee = new Person(2, "Octavia", "Donald");

            Person assigneeToFind = new Person(2, "Octavia", "Donald");

            //Act
            Todo[] result = _todoItems.FindByAssignee(assigneeToFind);

            //Assert
            //Assert.DoesNotContain<Todo>(specificTodo1, result);
            //Assert.Contains<Todo>(specificTodo3, result);
            //Assert.Contains<Todo>(specificTodo1, result);
            Assert.True(result.Length == 2);
        }

        [Fact]
        public void FindUnassignedTodoItemsWorkCorrectly()
        {
            //Arrange
            TodoItemsTestData();

            Todo specificTodo1 = _todoItems.FindById(1);
            specificTodo1.Assignee = new Person(1, "Bellamy", "Donald");

            Todo specificTodo2 = _todoItems.FindById(2);
            specificTodo2.Assignee = new Person(2, "Octavia", "Donald");

            Todo specificTodo3 = _todoItems.FindById(3); //by default Done is false
            specificTodo3.Assignee = new Person(3, "Indra", "Koi");

            //Act
            Todo[] result = _todoItems.FindUnassignedTodoItems();

            Assert.True(result.Length == 2);
        }

        [Fact]
        public void RemoveItemInTodoItemsWorkCorrectly()
        {
            //Arrange
            TodoItemsTestData();
            Todo[] allTodo = _todoItems.FindAll();

            int id = 1;
            Todo removedTodo = new Todo(1, "Going supermarket");
            Todo expected2 = new Todo(2, "Doing assignment");
            Todo expected3 = new Todo(3, "Greet friends");
            Todo expected4 = new Todo(4, "Playing football");
            Todo expected5 = new Todo(5, "Going saloon to make hair");

            //Act
            Todo[] result = _todoItems.RemoveItemInTodoItems(id);

            //Assert
            Assert.True(result.Length == 4);

            Assert.False(result[0].TodoId == removedTodo.TodoId);
            Assert.True(result[0].TodoId == expected2.TodoId);
            Assert.True(result[1].TodoId == expected3.TodoId);
            Assert.True(result[2].TodoId == expected4.TodoId);
            Assert.True(result[3].TodoId == expected5.TodoId);
        }

        public Todo[] TodoItemsTestData()
        {
            _todoItems.Clear();
            _todoItems.AddTodo("Going supermarket");
            _todoItems.AddTodo("Doing assignment");
            _todoItems.AddTodo("Greet friends");
            _todoItems.AddTodo("Playing football");
            _todoItems.AddTodo("Going saloon to make hair");
            return TodoItems.Todo;
        }
    }
}
