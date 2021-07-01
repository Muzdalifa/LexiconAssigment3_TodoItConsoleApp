using LexiconAssigment3_TodoItConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconAssigment3_TodoItConsoleApp.Data
{
    public class People
    {
        private static Person[] persons = new Person[0];

        public static Person[] Person 
        {
            get { return persons; }
        }

        public int Size()
        {
            return persons.Length;
        }

        public Person[] FindAll()
        {
            return persons;
        }

        public Person FindById(int personId)
        {
            try
            {                
                Person specificPerson = Array.Find(persons, p => p.PersonId == personId);
                if(specificPerson != null)
                {
                    return specificPerson;
                }
                else
                {
                    return null;
                }
            }
            catch (NullReferenceException)
            {

                Console.WriteLine( "Array is empty");
                return null;
            }    
        }

        public Person[] AddPerson(Person person)
        {            
            //Resizing array
            Array.Resize<Person>(ref persons, PersonSequencer.NextPersonId());
            //Assign to the last index
            persons[PersonSequencer.PersonId -1 ] = person;    
            return persons;            
        }

        public void Clear()
        {
            //Resize array to initial value
            Array.Resize<Person>(ref persons, 0);

            //Console.WriteLine($"Check this:  {persons.Length}");
            //
            //reset index to 0 
            PersonSequencer.Reset();
        }
    }
}
