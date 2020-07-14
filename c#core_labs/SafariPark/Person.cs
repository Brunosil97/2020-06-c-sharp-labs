using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace SafariPark
{
    class Person
    {
        //attributes of the class
        private string _firstName; //only the class person can access
        private string _lastName;

        public int Age { get; set; } //setting a property

        //create a constructor: has no return value but must have the same name as the class
        public Person(string firstName, string lastName)
        {
            //setting the private variables to whatever the constructor receives as arguments
            _firstName = firstName;
            _lastName = lastName;
        }

        public string GetFullName() //public method that can be accessed
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
