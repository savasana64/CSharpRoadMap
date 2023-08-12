using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string color, string material) 
        { 
            this.Color = color;
            this.Material = material;

            DestructionSound = "chairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("playing the destruction sound {0} ", DestructionSound);
            Console.WriteLine("spawning the chair part");
        }

    }
}
