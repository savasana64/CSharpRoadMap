using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    internal class VgaGraphicsCard
    {
        public VgaStream GetVgaStream()
        { 
            VgaStream vgaSream = new VgaStream();
            //we pass an emty bate as example
            vgaSream.setData(new byte[] { });
            return vgaSream;
        }
    }
}
