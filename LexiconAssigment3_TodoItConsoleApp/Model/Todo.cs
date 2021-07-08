using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconAssigment3_TodoItConsoleApp.Model
{
    public class Todo
    {
        //Fields
        readonly int todoId;
        string description;
        bool done;
        Person assignee;

        //Properties
        public int TodoId  { get { return todoId; } }

        public string Description
        {
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please fill the description.");
                }

                description = value;
            }
            get { return description; }
        }

        public bool Done { 
            set
            {
                done = value;
            }
            get { return done; }
        }

        public Person Assignee { set; get ; }

        //Constructor
        public Todo(int id, string description)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Todo Id must start from 1.");
            }

            todoId = id;
            Description = description;
        }

        public string PrintInfo()
        {
            return $"{TodoId} : {Description} {Assignee?.PrintInfo()}  DONE: {(Done ? "YES" : "NO")}";
        }

    }
}
