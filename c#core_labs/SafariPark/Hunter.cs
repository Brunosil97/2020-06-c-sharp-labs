﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person, IShootable//this is how you inherit from a parent class
    {
        protected object _camera;
       
        public IShootable Shooter { get; set; }
        

        public Hunter(string firstName, string lastName, IShootable shooter) : base(firstName, lastName) //base retrives the arguments
        {
            Shooter = shooter;
            //dont need to call firstname and last name, as it gets it from the person class
        }

        //public Hunter()//default constructor
        //{

        //}

        public string Shoot()
        {
            //can call methods like so as it inherits from the parent class
            return $"{GetFullName()}: Shooting a {Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} camera: {_camera}";
        }
 
    }

    //public class MonsterHunter : Hunter
    //{
    //    private string _weapon;
    //    public MonsterHunter(string firstName, string lastName, string camera, string weapon) : base(firstName, lastName, camera)
    //    {
    //        _weapon = weapon;
    //    }
       
    //    public sealed override string ToString()
    //    {
    //        return $"{base.ToString()} WEAPON : {_weapon}";
    //    }
    //}
}
