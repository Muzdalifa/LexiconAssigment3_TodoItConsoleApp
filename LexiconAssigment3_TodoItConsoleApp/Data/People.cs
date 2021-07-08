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

        //return the length of Person array
        public int Size()
        {
            return persons.Length;
        }

        //return the Person array
        public Person[] FindAll()
        {
            return persons;
        }

        //return the person that has a matching personId as the passed in parameter.
        public Person FindById(int personId)
        {
            return Array.Find(persons, p => p.PersonId == personId);
        }

        //creates a new Person, adds the newly created object in the array and then return the created object.
        public Person[] AddPerson(string firstName, string lastName)
        {
            //if persons array is empty we start with id 1
            if (persons.Length == 0)
            {
                PersonSequencer.Reset();
            }
            Person person = new Person(PersonSequencer.NextPersonId(), firstName, lastName);

            //Resizing array
            Array.Resize<Person>(ref persons, Size() + 1);

            //Assign added persons to the last index of the array
            persons[Size() -1 ] = person;    

            return persons;            
        }

        //clears all Person objects from the Person array
        public void Clear()
        {
            //Resize array to initial value
            Array.Resize<Person>(ref persons, 0);

            //reset index to 0 
            PersonSequencer.Reset();
        }

        //public Person[] RemoveItemInPersonArray(int id)
        //{
        //    persons = Array.FindAll(persons, person => person?.PersonId != id);
        //    return persons;
        //}

    }
}
