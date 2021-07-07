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
            private set
            {
                todos = value;
            }
            get { return todos; }
        }

        public int Size()
        {
            return todos.Length;
        }

        public Todo[] FindAll()
        {
            return todos;
        }

        public Todo FindById(int todoId)
        {
            //Todo specificTodo = Array.Find(todos, p => p.TodoId == todoId);
            //if (specificTodo != null)
            //{
            //    return specificTodo;
            //}
            //else
            //{
            //    //throw new NullReferenceException("The id is not in the list of Todo.");
            //    return null;
            //}

            //Array.Find() by default return null if it doesnt found.
            return Array.Find(todos, p => p.TodoId == todoId);
        }

        public Todo[] AddTodo(string description)
        {
            Todo todo = new Todo(TodoSequencer.NextTodoId(),description); 
            //Resizing array
            Array.Resize<Todo>(ref todos, Size() + 1);
            //Assign value to the last index
            todos[Size() - 1] = todo;
            return todos;
        }

        public void Clear()
        {
            //Resize array to initial value
            Array.Resize<Todo>(ref todos, 0);
            
            //reset index to 0 
            TodoSequencer.Reset();
        }

        //Returns array with objects that has a matching done status.
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            return Array.FindAll(todos, (todo) => todo.Done == doneStatus); 
        }

        //Returns array with objects that has an assignee with a personId matching.
        public Todo[] FindByAssignee(int personId)
        {
            return Array.FindAll(todos, (todo) => (todo.Assignee != null) ? todo.Assignee.PersonId == personId : false);
        }

        //Returns array with objects that has sent in Person.
        public Todo[] FindByAssignee(Person assignee)
        {   //To check if the object is null I use (?) so it doesn't crush
            return Array.FindAll(todos, (todo) => todo.Assignee?.PersonId == assignee.PersonId);
        }

        //Returns an array of objects that does not have an assignee set
        public Todo[] FindUnassignedTodoItems()
        {
            return Array.FindAll(todos, (todo) => todo.Assignee == null);
        }

        public Todo[] RemoveItemInTodoItems(int id)
        {
            todos =  Array.FindAll(todos, todo => todo?.TodoId != id);
            return todos;
        }
    }
}
