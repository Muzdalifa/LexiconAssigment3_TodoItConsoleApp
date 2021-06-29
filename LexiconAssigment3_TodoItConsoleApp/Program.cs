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

            Person person1 = new Person("Ana", "Mikael");
            Console.WriteLine(person1.PrintInfo());
            Person person2 = new Person("Sune", "Andersson");
            Console.WriteLine(person2.PrintInfo());

        }

    }
}
