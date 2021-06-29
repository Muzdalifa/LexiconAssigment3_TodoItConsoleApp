using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconAssigment3_TodoItConsoleApp.Data
{
    public class PersonSequencer
    {
        //Set initial personId value to 0
        private static int personId = 0;
        public static int PersonId
        {
            private set
            {   
                //set the next personId
                personId = NextPersonId();
            }
            get
            {
                return personId;
            }
        }

        //increment personId and return the next personId value.
        public static int NextPersonId()
        {
            return ++personId;
        }

        public static int Reset()
        {
            return personId = 0;
        }


 
    }
}
