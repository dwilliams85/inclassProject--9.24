using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Athlete : Person
    {
        public string jerseyNumber;
        public Person assistantCoach;



        /// <summary>

        /// Default constructor attempt 1

        /// </summary>

        public Athlete()

        {

            jerseyNumber = "22";

            lastName = "Doe";

        }



        /// <summary>

        /// Default constructor that uses inheritance

        /// </summary>

        //public Athlete() : base()

        //{

        //  jerseyNumber = "22";

        //} 
    }
}
