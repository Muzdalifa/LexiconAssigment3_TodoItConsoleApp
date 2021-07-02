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
            return Array.Find(todos, p => p.TodoId == todoId);
        }

        public Todo[] AddTodo(Todo todo)
        {
            //Resizing array
            Array.Resize<Todo>(ref todos, TodoSequencer.NextTodoId());
            //Assign value to the last index
            todos[TodoSequencer.TodoId - 1] = todo;
            return todos;
        }

        public void Clear()
        {
            //Resize array to initial value
            Array.Resize<Todo>(ref todos, 0);
            
            //reset index to 0 
            TodoSequencer.Reset();
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            return Array.FindAll(todos, (todo) => todo.Done == doneStatus); 
        }

        public Todo[] FindByAssignee(int personId)
        {
            return Array.FindAll(todos, (todo) => (todo.Assignee != null) ? todo.Assignee.PersonId == personId : false);
        }

        public Todo[] FindByAssignee(Person assignee)
        {   //To check if the object is null I use (?) so it doesn't crush
            return Array.FindAll(todos, (todo) => todo.Assignee?.PersonId == assignee.PersonId);
        }

        public Todo[] FindUnassignedTodoItems()
        {
            return Array.FindAll(todos, (todo) => todo.Assignee == null);
        }


    }
}
