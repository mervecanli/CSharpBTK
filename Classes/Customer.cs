using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //property
        public int Id { get; set; }

        //private string _firstName;
        //public string FirstName 
        //{ 
        //    get { return "Sayın " + _firstName; }
        //    set { _firstName=value; } 
        //}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


        //field
        //public string FirstName;
    }
}
