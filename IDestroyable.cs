﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    interface IDestroyable
    {
        string DestructionSound { get; set; }

        void Destroy();
    }
}
