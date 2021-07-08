using LexiconAssigment3_TodoItConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconAssigment3_TodoItConsoleApp.Data
{
    public class TodoItems
    {
        private static Todo[] todos = new Todo[0];

        public static Todo[] Todo
        {
            get { return todos; }
        }

        //returns the length of Todo array
        public int Size()
        {
            return todos.Length;
        }

        //return Todo array
        public Todo[] FindAll()
        {
            return todos;
        }

        //returns todo that has a matching personId as the passed in parameter.
        public Todo FindById(int todoId)
        {
            //Array.Find() by default return null if it doesn't found.
            return Array.Find(todos, p => p.TodoId == todoId);
        }

        //creates a new todo, adds the newly created object in the array and then return the created object.
        public Todo[] AddTodo(string description)
        {
            //if persons array is empty we start with id 1
            if (todos.Length == 0)
            {
                TodoSequencer.Reset();
            }
            Todo todo = new Todo(TodoSequencer.NextTodoId(), description); 

            //Resizing todos array
            Array.Resize<Todo>(ref todos, Size() + 1);

            //Assign added todo to the last index of the array
            todos[Size() - 1] = todo;

            return todos;
        }

        //clears all Person objects from the Person array
        public void Clear()
        {
            //Resize array to initial value
            Array.Resize<Todo>(ref todos, 0);
            
            //reset index to 0 
            TodoSequencer.Reset();
        }

        ////Returns array with objects that has a matching done status.
        //public Todo[] FindByDoneStatus(bool doneStatus)
        //{
        //    return Array.FindAll(todos, (todo) => todo.Done == doneStatus); 
        //}

        ////Returns array with objects that has an assignee with a personId matching.
        //public Todo[] FindByAssignee(int personId)
        //{
        //    return Array.FindAll(todos, (todo) => (todo.Assignee != null) ? todo.Assignee.PersonId == personId : false);
        //}

        ////Returns array with objects that has sent in Person.
        //public Todo[] FindByAssignee(Person assignee)
        //{   //To check if the object is null I use (?) so it doesn't crush
        //    return Array.FindAll(todos, (todo) => todo.Assignee?.PersonId == assignee.PersonId);
        //}

        ////Returns an array of objects that does not have an assignee set
        //public Todo[] FindUnassignedTodoItems()
        //{
        //    return Array.FindAll(todos, (todo) => todo.Assignee == null);
        //}

        //public Todo[] RemoveItemInTodoItems(int id)
        //{
        //    todos =  Array.FindAll(todos, todo => todo?.TodoId != id);
        //    return todos;
        //}
    }
}
