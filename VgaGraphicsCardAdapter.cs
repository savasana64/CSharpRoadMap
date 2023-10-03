using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    internal class VgaGraphicsCardAdapter
    {
        private VgaGraphicsCard _vgaGraphicsCard;

        public VgaGraphicsCardAdapter(VgaGraphicsCard vgaGraphicsCard) 
        {
            _vgaGraphicsCard = vgaGraphicsCard;
        }

        public DviStream GetDviStream()
        {
            byte[] data = _vgaGraphicsCard.GetVgaStream().getData();

            //here: process the vga and convert it to Dvi

            byte[] DviVideoData = ConvertFromVgaToDvi(data);

            DviStream dviStream = new DviStream();
            dviStream.setData(DviVideoData);

            return dviStream;
        }
        private byte[] ConvertFromVgaToDvi(byte[] input)
        {
            Console.WriteLine("Converted VGA video to DVI Video");

            return new byte[] { };
        }


    }
}
