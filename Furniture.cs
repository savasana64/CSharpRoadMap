using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        //default constructor
        public Furniture()
        {
            this.Color = "White";
            this.Material = "Wood";
        }

        //simple constructor
        public Furniture(string color, string material)
        { 
            this.Color = color;
            this.Material = material;
        }
    }
}
