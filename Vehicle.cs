using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class Vehicle
    {
        public float Speed { get; set; }

        public string Color { get; set; }

        //default constructor

        public Vehicle() 
        {
            Speed = 120f;
            Color = "White";
        }

        //simple Constructor
        public Vehicle(float speed, string color)
        { 
            Speed = speed;
            Color = color;

        }
    }
}
