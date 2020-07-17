using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return $"{base.ToString()} {_brand}";
        }
    }
}
