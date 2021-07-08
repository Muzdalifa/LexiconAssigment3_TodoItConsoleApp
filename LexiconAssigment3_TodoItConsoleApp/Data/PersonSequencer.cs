using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconAssigment3_TodoItConsoleApp.Data
{
    public class PersonSequencer
    {
        private static int personId;
        //public static int PersonId //to be deleted
        //{
        //    private set
        //    {
        //        //set the next personId
        //        personId = NextPersonId();
        //    }
        //    get
        //    {
        //        return personId;
        //    }
        //}

        //increment personId and return the next personId value.
        public static int NextPersonId()
        {
            return ++personId;
        }

        //sets the personId variable to 0.
        public static int Reset()
        {
            return personId = 0;
        } 


    }
}
