using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class Car : Vehicle, IDestroyable
    {
        //NOTE: when you implement an interface you need to implement all its members
        public string DestructionSound { get; set; }

        //simple constructor

        public Car(float speed, string color) : base(speed, color) //using base is ALSO a valid option
        { 
            this.Speed = speed;
            this.Color = color;

            DestructionSound = "carExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public List<IDestroyable> DestroyablesNearby;

        public void Destroy()
        {
            Console.WriteLine("play the destruction sound {0} ", DestructionSound);
            Console.WriteLine("create fire");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }

    }
} 
