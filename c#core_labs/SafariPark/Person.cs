using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace SafariPark
{
    public class Person
    {
        //attributes of the class
        protected string _firstName; //only the class person can access
        private string _lastName;

        //can make attributes protected: still private but classes dereived from person can use it
        // protected string _firstName

        //
        private int _age;

        public int Age 
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        //public int Age { get; set; } //setting a property

        //create a constructor: has no return value but must have the same name as the class
        //constructor is called when a new Person object is created
        public Person(string firstName, string lastName)
        {
            //setting the private variables to whatever the constructor receives as arguments
            _firstName = firstName;
            _lastName = lastName;
        }

        //overloading the constructor
        //public Person(string firstName, string lastName, int aAge)
        //{
        //    _firstName = firstName;
        //    _lastName = lastName;
        //    _age = aAge;
        //}

        public string GetFullName() //public method that can be accessed and gets name of an instance
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
