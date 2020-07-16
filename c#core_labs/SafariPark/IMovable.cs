using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public interface IMovable
    {
        //Place our move methods in here that all classes can access

        string Move();

        string Move(int times);
    }
}
