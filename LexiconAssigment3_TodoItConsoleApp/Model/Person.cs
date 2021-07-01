using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconAssigment3_TodoItConsoleApp.Model
{
    public class Person
    {
        //Fields
        //private static int personCounter = 0;
        private readonly int personId;
        private string firstName;
        private string lastName;

        //Properties
        //public static int PersonCounter { get { return personCounter; } }
        public int PersonId { get { return personId; } }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be empty.");
                }

                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be empty.");
                }

                lastName = value;
            }
        }

        public Person(int id, string firstName, string lastName)
        {
            personId = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string PrintInfo()
        {
            return $"Person {personId} : {FirstName} {LastName}";
        }


    }
}
