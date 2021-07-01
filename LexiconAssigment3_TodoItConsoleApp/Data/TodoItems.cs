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
            try
            {
                Todo specificTodo = Array.Find(todos, p => p.TodoId == todoId);
                if (specificTodo != null)
                {
                    return specificTodo;
                }
                else
                {
                    return null;
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is empty");
                return null;
            }
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

            //Console.WriteLine($"Check this:  {todos.Length}");
     
            //reset index to 0 
            TodoSequencer.Reset();
        }
    }
}
