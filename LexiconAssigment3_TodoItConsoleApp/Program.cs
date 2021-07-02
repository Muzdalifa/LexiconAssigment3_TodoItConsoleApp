using LexiconAssigment3_TodoItConsoleApp.Data;
using LexiconAssigment3_TodoItConsoleApp.Model;
using System;

namespace LexiconAssigment3_TodoItConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person(1,"Ali", "Kassim");
            //Console.WriteLine(person1.PrintInfo());
            //Person person2 = new Person(2, "Sune", "Andersson");
            //Console.WriteLine(person2.PrintInfo());

            //Console.WriteLine("TODO:");
            //Todo todo = new Todo(1, "Going supermarket");
            //Console.WriteLine(todo.PrintInfo());
            //Todo todo2 = new Todo(2, "Cooking food");
            //Console.WriteLine(todo2.PrintInfo());

            //PersonSequencer 
            //Console.WriteLine(PersonSequencer.PersonId);
            //Console.WriteLine(PersonSequencer.NextPersonId());
            //Console.WriteLine(PersonSequencer.NextPersonId());
            //Console.WriteLine(PersonSequencer.Reset());
            //Console.WriteLine(PersonSequencer.NextPersonId());

            //TodoSequencer 
            //Console.WriteLine(TodoSequencer.TodoId);
            //Console.WriteLine(TodoSequencer.NextTodoId());
            //Console.WriteLine(TodoSequencer.NextTodoId());
            //Console.WriteLine(TodoSequencer.Reset());
            //Console.WriteLine(TodoSequencer.NextTodoId());

            //People
            //People p1 = new People();

            //p1.AddPerson(new Person(1, "Muzda", "Ali"));
            //p1.AddPerson(new Person(2, "Selma", "Hamza"));
            //p1.AddPerson(new Person(3, "Ana", "Peter"));
            //Console.WriteLine(p1.FindById(1));

            //Person[] person1 = p1.FindAll();

            //foreach (var item in person1)
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}

            //p1.Clear();
            //Console.WriteLine($"Check length: {People.Person.Length}");

            //p1.AddPerson(new Person(1, "Muzda", "Ali"));
            //p1.AddPerson(new Person(2, "Selma", "Hamza"));
            //p1.AddPerson(new Person(3, "Ana", "Peter"));
            ////Console.WriteLine(p1.FindById(1));

            //Person[] person2 = p1.FindAll();

            //foreach (var item in person2)
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}

            //TodoItems
            TodoItems todoItems = new TodoItems();
            todoItems.AddTodo(new Todo(1, "Going supermarket"));
            todoItems.AddTodo(new Todo(2, "Doing assignment"));
            todoItems.AddTodo(new Todo(3, "Greet friends"));
            todoItems.AddTodo(new Todo(4, "Playing football"));
            todoItems.AddTodo(new Todo(5, "Going saloon to make hair"));

            Todo[] result = todoItems.FindAll();
            Console.WriteLine("All Todo item:");
            foreach (var item in result)
            {
                Console.WriteLine(item.PrintInfo());
            }

            //Todo specificTodo1 = todoItems.FindById(1);
            ////Properties that are not needed during object instantiation can be changed latter(like Asignee here )
            ////Add Assignee to Todo item
            //specificTodo1.Assignee = new Person(1, "Bellamy", "Donald");
            //specificTodo1.Done = true;
            //Todo specificTodo2 = todoItems.FindById(2);
            //specificTodo2.Assignee = new Person(2, "Octavia", "Donald");
            //specificTodo2.Done = true;
            //Todo specificTodo3 = todoItems.FindById(3); //by default Done is false
            //specificTodo3.Assignee = new Person(3, "Indra", "Koi");      
            //Console.WriteLine();

            //Console.WriteLine("Todo Find by Assignee ID ");
            //foreach (var item in todoItems.FindByAssignee(1))
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}

            //Console.WriteLine("Todo Find by Assignee by Person object ");
            //Person person1 = new Person(2, "Octavia", "Donald");
            //foreach (var item in todoItems.FindByAssignee(person1))
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}

            //Console.WriteLine("Todo Done status = YES ");
            //foreach (var item in todoItems.FindByDoneStatus(true))
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}

            //Console.WriteLine("Unassigned Todo Items ");
            //foreach (var item in todoItems.FindUnassignedTodoItems())
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}

            todoItems.RemoveItemInTodoItems(2);

            Console.WriteLine("Todo after removing index 2:");
            foreach (var item in TodoItems.Todo)
            {
                Console.WriteLine(item?.PrintInfo());
            }


        }

    }
}
