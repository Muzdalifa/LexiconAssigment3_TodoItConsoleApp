using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconAssigment3_TodoItConsoleApp.Data
{
    public class TodoSequencer
    {
        private static int todoId;
        //public static int TodoId //To be deleted
        //{
        //    private set
        //    {
        //        //set the next todoId
        //        todoId = NextTodoId();
        //    }
        //    get
        //    {
        //        return todoId;
        //    }
        //}

        //increment todoId and return the next todoId value.
        public static int NextTodoId()
        {
            return ++todoId;
        }

        public static int Reset()
        {
            return todoId = 0;
        }

    }
}
