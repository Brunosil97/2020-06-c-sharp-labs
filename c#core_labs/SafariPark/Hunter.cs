using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person //this is how you inherit from a parent class
    {
        private string _camera;

        public Hunter(string firstName, string lastName, string camera = "") : base(firstName, lastName) //base retrives the arguments
        {
            _camera = camera;
            //dont need to call firstname and last name, as it gets it from the person class
        }

        public string Shoot()
        {
            //can call methods like so as it inherits from the parent class
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }
    }
}
