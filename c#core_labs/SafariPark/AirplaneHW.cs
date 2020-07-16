using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;


        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
            
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude {_altitude} metres";
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude {_altitude} metres";
        }

        public void Ascend(int num)
        {
            _altitude += num;
        }

        public void Descend(int num)
        {
             _altitude -= num;
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude: {_altitude}";
        }
    }
}
