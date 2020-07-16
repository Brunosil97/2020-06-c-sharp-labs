using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Vehicle : IMovable
    {
        protected int _capacity;
        protected int _numPassengers;
        protected int _speed;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set 
            {
                if (value <= _capacity && value >= 0)
                {
                    _numPassengers = value;
                }
                else if (value > _capacity)
                {
                    _numPassengers = _capacity;
                }
            }
        }
        protected int Position { get;  set; }

        public Vehicle(int capacity = 6, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
           
        }

        public Vehicle()
        {
            _speed = 10;
        }
        public virtual string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }
        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public override string ToString()
        {
            return $"{base.ToString()} capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: {Position}";
        }
    }
}
