using LexiconAssigment3_TodoItConsoleApp.Data;
using LexiconAssigment3_TodoItConsoleApp.Model;
using System;

namespace LexiconAssigment3_TodoItConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person
            Console.WriteLine("------Person------");
            Person firstePrson = new Person(1, "Ali", "Kassim");
            Console.WriteLine(firstePrson.PrintInfo());
            Person secondPerson = new Person(2, "Sune", "Andersson");
            Console.WriteLine(secondPerson.PrintInfo());
            Console.WriteLine("\n");

            //Todo
            Console.WriteLine("------Todo------");
            Todo todo = new Todo(1, "Going supermarket");
            Console.WriteLine(todo.PrintInfo());
            Todo todo2 = new Todo(2, "Cooking food");
            Console.WriteLine(todo2.PrintInfo());
            Console.WriteLine("\n");

            //PersonSequencer
            Console.WriteLine("------PersonSequencer------");
            //Console.WriteLine(PersonSequencer.PersonId);
            Console.WriteLine(PersonSequencer.NextPersonId());
            Console.WriteLine(PersonSequencer.NextPersonId());
            Console.WriteLine(PersonSequencer.Reset());
            Console.WriteLine(PersonSequencer.NextPersonId());
            Console.WriteLine("\n");

            //TodoSequencer
            Console.WriteLine("------TodoSequencer------");
            //Console.WriteLine(TodoSequencer.TodoId);
            Console.WriteLine(TodoSequencer.NextTodoId());
            Console.WriteLine(TodoSequencer.NextTodoId());
            Console.WriteLine(TodoSequencer.Reset());
            Console.WriteLine(TodoSequencer.NextTodoId());

            ////People
            //People p1 = new People();

            //p1.AddPerson("Muzda", "Ali");
            //p1.AddPerson("Selma", "Hamza");
            //p1.AddPerson("Ana", "Peter");

            //Person[] allPerson = p1.FindAll();
            //Console.WriteLine("---------- Find all added people :----------");
            //foreach (Person item in allPerson)
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}
            //Console.WriteLine("\n");

            //Console.WriteLine("----------Find person with id 1 :----------");
            //Console.WriteLine(p1.FindById(1).PrintInfo());
            //Console.WriteLine("\n");

            //p1.Clear();
            //Console.WriteLine("----------Legth of Person array after calling Clear method :----------");
            //Console.WriteLine($"Check length: {p1.Size()}");
            //Console.WriteLine("\n");

            //Console.WriteLine("----------Add new person to the Person array :----------");
            //p1.AddPerson("Muzda", "Ali");
            //p1.AddPerson("Selma", "Hamza");
            //p1.AddPerson("Ana", "Peter");

            //Person[] person2 = p1.FindAll();

            //foreach (var item in person2)
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}
            //Console.WriteLine("\n");

            ////TodoItems
            //TodoItems todoItems = new TodoItems();
            //todoItems.AddTodo("Going supermarket");
            //todoItems.AddTodo("Doing assignment");
            //todoItems.AddTodo("Greet friends");
            //todoItems.AddTodo("Playing football");
            //todoItems.AddTodo("Going saloon to make hair");

            //Todo[] result = todoItems.FindAll();

            //Console.WriteLine("----------Find all Todo items:----------");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}
            //Console.WriteLine("\n");

            //Console.WriteLine("----------Todo with id 3 is :----------");
            //Todo specificTodo = todoItems.FindById(3);
            //Console.WriteLine(specificTodo?.PrintInfo());

            //Todo specificTodo1 = todoItems.FindById(1);
            ////Add Assignee to Todo item
            //specificTodo1.Assignee = new Person(1, "Bellamy", "Donald");
            //specificTodo1.Done = true; //Properties that are not needed during object instantiation can be changed latter(like Asignee here )
            //Todo specificTodo2 = todoItems.FindById(2);
            //specificTodo2.Assignee = new Person(2, "Octavia", "Donald");
            //specificTodo2.Done = true;
            //Todo specificTodo3 = todoItems.FindById(3); //by default Done is false
            //specificTodo3.Assignee = new Person(3, "Indra", "Koi");

            //Console.WriteLine("----------Todo Find by Assignee ID 1----------");
            //foreach (var item in todoItems.FindByAssignee(1))
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}
            //Console.WriteLine("\n");

            //Console.WriteLine("----------Find Todo using Find by Assignee method by Person object ((2, \"Octavia\", \"Donald\"))---------- ");
            //Person person1 = new Person(2, "Octavia", "Donald");
            //foreach (var item in todoItems.FindByAssignee(person1))
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}
            //Console.WriteLine("\n");

            //Console.WriteLine("----------Todo Done status = YES---------- ");
            //foreach (var item in todoItems.FindByDoneStatus(true))
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}
            //Console.WriteLine("\n");

            //Console.WriteLine("----------Unassigned Todo Items----------");
            //foreach (var item in todoItems.FindUnassignedTodoItems())
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}
            //Console.WriteLine("\n");

            //todoItems.RemoveItemInTodoItems(2);

            //Console.WriteLine("----------Todo after removing index 2:----------");
            //foreach (var item in TodoItems.Todo)
            //{
            //    Console.WriteLine(item?.PrintInfo());
            //}
            //Console.WriteLine("\n");


        }

    }
}
