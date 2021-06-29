using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconAssigment3_TodoItConsoleApp.Data
{
    public class TodoSequencer
    {
        //Set initial todoId value to 0
        private static int todoId = 0;
        public static int TodoId
        {
            private set
            {
                //set the next todoId
                todoId = NextTodoId();
            }
            get
            {
                return todoId;
            }
        }

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
