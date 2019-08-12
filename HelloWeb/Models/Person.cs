using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWeb.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string OS { get; set; }

        public Person()
        {
            FirstName = "";
            LastName = "";
            OS = "";

        }

        public string getPersonName()
        {
            return FirstName + " " + LastName;
        }
    }
}
