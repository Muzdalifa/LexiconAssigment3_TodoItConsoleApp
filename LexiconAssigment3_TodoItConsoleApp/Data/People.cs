using LexiconAssigment3_TodoItConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconAssigment3_TodoItConsoleApp.Data
{
    public class People
    {
        private static Person[] persons = new Person[0];

        public static Person[] Persons
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
            return Array.Find(persons, p => p.PersonId == personId);
        }

        public Person[] AddPerson(string firstName, string lastName)
        {
            Person person = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            //Resizing array
            Array.Resize<Person>(ref persons, Size() + 1);
            //Assign to the last index
            persons[Size() -1 ] = person;    
            return persons;            
        }

        public void Clear()
        {
            //Resize array to initial value
            Array.Resize<Person>(ref persons, 0);

            ////reset index to 0 
            PersonSequencer.Reset();
        }

        public Person[] RemoveItemInPersonArray(int id)
        {
            persons = Array.FindAll(persons, person => person?.PersonId != id);
            return persons;
        }

    }
}
