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
        public int TodoId
        {
            get { return todoId; }
        }

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
            private set
            {
                done = value;
            }
            get { return done; }
        }

        public int AssigneeId { get; set; }
        public Person Assignee { get; set; }
        

        //Constructors
        public Todo(int id, string description)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Todo Id must start from 1.");
            }

            todoId = id;
            Description = description;

        }

        public Todo(int id, string description, bool done, Person assignee) :this(id, description)
        {
            Done = done;
            Assignee = assignee;
        }

        public string PrintInfo()
        {
            return $"{TodoId} : {Description} {(Done ? "YES" : "NO")}";
        }

    }
}
