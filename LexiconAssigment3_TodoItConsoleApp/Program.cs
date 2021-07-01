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
            People p1 = new People();
            //p1.AddPerson(new Person(1,"Muzda", "Ali"));
            //p1.AddPerson(new Person(2,"Maryam", "Kassim"));
            //p1.AddPerson(new Person(3,"Juma", "Shaame"));

            //foreach (var item in People.Person)
            //{
            //    Console.WriteLine(item.PrintInfo());
            //}

            p1.AddPerson(new Person(1, "Muzda", "Ali"));
            p1.AddPerson(new Person(2, "Selma", "Hamza"));
            p1.AddPerson(new Person(3, "Ana", "Peter"));
            //Console.WriteLine(p1.FindById(1));

            Person[] person1 = p1.FindAll();

            foreach (var item in person1)
            {
                Console.WriteLine(item.PrintInfo());
            }

            //Person[] firstPerson = p1.AddPerson(new Person(1, "Muzda", "Ali"));
            //Console.WriteLine(firstPerson[0].PrintInfo());

            p1.Clear();
            Console.WriteLine($"Check length: {People.Person.Length}");

            p1.AddPerson(new Person(1, "Muzda", "Ali"));
            p1.AddPerson(new Person(2, "Selma", "Hamza"));
            p1.AddPerson(new Person(3, "Ana", "Peter"));
            //Console.WriteLine(p1.FindById(1));

            Person[] person2 = p1.FindAll();

            foreach (var item in person2)
            {
                Console.WriteLine(item.PrintInfo());
            }





        }

    }
}
