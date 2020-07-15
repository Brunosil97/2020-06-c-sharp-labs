using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set { if (value <= _capacity && value >= 0) _numPassengers = value; }
        }
        public int Position { get; private set; }

        public Vehicle(int capacity = 6, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
           
        }

        public Vehicle()
        {
            _speed = 10;
        }
        public string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }
        public string Move()
        {
            Position += _speed;
            return "Moving along";
        }
    }
}
