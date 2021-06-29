using LexiconAssigment3_TodoItConsoleApp.Data;
using LexiconAssigment3_TodoItConsoleApp.Model;
using System;

namespace LexiconAssigment3_TodoItConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(firstPerson.PersonId);
            //Console.WriteLine(firstPerson.FirstName);
            //Console.WriteLine(firstPerson.LastName)

            //Person person1 = new Person("", "");
            //Console.WriteLine(person1.PrintInfo());
            //Person person2 = new Person("Sune", "Andersson");
            //Console.WriteLine(person2.PrintInfo());

            //Console.WriteLine("TODO:");
            //Todo todo = new Todo(1, "Going supermarket");
            //Console.WriteLine(todo.PrintInfo());
            //Todo todo2 = new Todo(2, "Cooking food");
            //Console.WriteLine(todo2.PrintInfo());

            //PersonSequencer 
            Console.WriteLine(PersonSequencer.PersonId);
            Console.WriteLine(PersonSequencer.NextPersonId());
            Console.WriteLine(PersonSequencer.NextPersonId());
            Console.WriteLine(PersonSequencer.Reset());
            Console.WriteLine(PersonSequencer.NextPersonId());




        }

    }
}
