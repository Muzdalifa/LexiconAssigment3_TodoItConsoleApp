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
            Assert.Contains<Todo>(todo1[0], result);
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

        [Fact]
        public void FindByDoneStatusTrueWorkCorrectly()
        {
            TodoItems todoItems = new TodoItems();
            todoItems.AddTodo(new Todo(1, "Going supermarket"));
            todoItems.AddTodo(new Todo(2, "Doing assignment"));
            todoItems.AddTodo(new Todo(3, "Greet friends"));
            todoItems.AddTodo(new Todo(4, "Playing football"));
            todoItems.AddTodo(new Todo(5, "Going saloon to make hair"));

            Todo specificTodo1 = todoItems.FindById(1);
            specificTodo1.Done = true;
            Todo specificTodo2 = todoItems.FindById(2);
            specificTodo2.Done = true;
            Todo specificTodo3 = todoItems.FindById(3); //by default Done is false
            

            //Act
            Todo[] result = todoItems.FindByDoneStatus(true);
            //Assert
            Assert.Contains<Todo>(specificTodo1, result);
            Assert.Contains<Todo>(specificTodo2, result);
            Assert.DoesNotContain<Todo>(specificTodo3, result);
        }

        [Fact]
        public void FindByDoneStatusFalseorWorkCorrectly()
        {
            TodoItems todoItems = new TodoItems();
            todoItems.AddTodo(new Todo(1, "Going supermarket"));
            todoItems.AddTodo(new Todo(2, "Doing assignment"));
            todoItems.AddTodo(new Todo(3, "Greet friends"));
            todoItems.AddTodo(new Todo(4, "Playing football"));
            todoItems.AddTodo(new Todo(5, "Going saloon to make hair"));

            Todo specificTodo1 = todoItems.FindById(1);
            specificTodo1.Done = true;
            Todo specificTodo2 = todoItems.FindById(2);
            specificTodo2.Done = true;
            Todo specificTodo3 = todoItems.FindById(3); //by default Done is false

            //Act
            Todo[] result = todoItems.FindByDoneStatus(false);
            //Assert
            Assert.Contains<Todo>(specificTodo3, result);
            Assert.DoesNotContain<Todo>(specificTodo1, result);
            Assert.DoesNotContain<Todo>(specificTodo2, result);
        }

        [Fact]
        public void FindByAssigneeIDWorkkCorrectly()
        {
            //Arrange
            TodoItems todoItems = new TodoItems();
            todoItems.AddTodo(new Todo(1, "Going supermarket"));
            todoItems.AddTodo(new Todo(2, "Doing assignment"));
            todoItems.AddTodo(new Todo(3, "Greet friends"));
            todoItems.AddTodo(new Todo(4, "Playing football"));
            todoItems.AddTodo(new Todo(5, "Going saloon to make hair"));

            Todo specificTodo1 = todoItems.FindById(1);
            specificTodo1.Assignee = new Person(1, "Bellamy", "Donald");
            Todo specificTodo2 = todoItems.FindById(2);
            specificTodo2.Assignee = new Person(2, "Octavia", "Donald");
            Todo specificTodo3 = todoItems.FindById(3); //by default Done is false
            specificTodo3.Assignee = new Person(3, "Indra", "Koi");

            //Act
            Todo[] result = todoItems.FindByAssignee(2);

            //Assert
            Assert.Contains<Todo>(specificTodo2, result);
            Assert.DoesNotContain<Todo>(specificTodo1, result);
        }

        [Fact]
        public void FindByAssigneeObjectCorrectly()
        {
            //Arrange
            TodoItems todoItems = new TodoItems();
            todoItems.AddTodo(new Todo(1, "Going supermarket"));
            todoItems.AddTodo(new Todo(2, "Doing assignment"));
            todoItems.AddTodo(new Todo(3, "Greet friends"));
            todoItems.AddTodo(new Todo(4, "Playing football"));
            todoItems.AddTodo(new Todo(5, "Going saloon to make hair"));

            Todo specificTodo1 = todoItems.FindById(1);
            specificTodo1.Assignee = new Person(1, "Bellamy", "Donald");
            Todo specificTodo2 = todoItems.FindById(2);
            specificTodo2.Assignee = new Person(2, "Octavia", "Donald");
            Todo specificTodo3 = todoItems.FindById(3); //by default Done is false
            specificTodo3.Assignee = new Person(2, "Octavia", "Donald");

            //Act
            Todo[] result = todoItems.FindByAssignee(new Person(2, "Octavia", "Donald"));

            //Assert
            Assert.DoesNotContain<Todo>(specificTodo1, result);
            Assert.Contains<Todo>(specificTodo2, result);
            Assert.Contains<Todo>(specificTodo3, result);
            
        }

        [Fact]
        public void FindUnassignedTodoItemsWorkCorrectly()
        {
            //Arrange
            TodoItems todoItems = new TodoItems();
            todoItems.AddTodo(new Todo(1, "Going supermarket"));
            todoItems.AddTodo(new Todo(2, "Doing assignment"));
            todoItems.AddTodo(new Todo(3, "Greet friends"));
            todoItems.AddTodo(new Todo(4, "Playing football"));
            todoItems.AddTodo(new Todo(5, "Going saloon to make hair"));

            Todo specificTodo1 = todoItems.FindById(1);
            specificTodo1.Assignee = new Person(1, "Bellamy", "Donald");
            Todo specificTodo2 = todoItems.FindById(2);
            specificTodo2.Assignee = new Person(2, "Octavia", "Donald");
            Todo specificTodo3 = todoItems.FindById(3); //by default Done is false
            specificTodo3.Assignee = new Person(3, "Indra", "Koi");

            //Act
            Todo[] result = todoItems.FindUnassignedTodoItems();

            //Assert
            Assert.Contains<Todo>(specificTodo2, result);
            Assert.DoesNotContain<Todo>(specificTodo1, result);
            Assert.DoesNotContain<Todo>(specificTodo2, result);
            Assert.DoesNotContain<Todo>(specificTodo3, result);
        }

        [Fact]
        public void RemoveItemInTodoItemsWorkCorrectly()
        {
            //Arrange
            TodoItems todoItems = new TodoItems();
            todoItems.AddTodo(new Todo(1, "Going supermarket"));
            //todoItems.AddTodo(new Todo(2, "Doing assignment"));
            //todoItems.AddTodo(new Todo(3, "Greet friends"));
            //todoItems.AddTodo(new Todo(4, "Playing football"));
            //todoItems.AddTodo(new Todo(5, "Going saloon to make hair"));

            int id = 1;
            //var expected1 = new Todo(1, "Going supermarket");
            //Todo expected2 = new Todo(2, "Doing assignment");
            //Todo expected3 = new Todo(3, "Greet friends");
            //Todo expected4 = new Todo(4, "Playing football");
            //Todo expected5 = new Todo(5, "Going saloon to make hair");

            //Act
            Todo[] result = todoItems.RemoveItemInTodoItems(id);

            //Assert
            //Assert.DoesNotContain(expected3, result);
            //Assert.Contains<Todo>(expected1, result);
            //Assert.Contains<Todo>(expected2, result);
            //Assert.Contains<Todo>(expected4, result);
            //Assert.Contains<Todo>(expected5, result);
            Assert.Empty(result);
        }
    }
}
