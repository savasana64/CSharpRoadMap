using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    internal class VgaStream
    {
        private byte[] _stream;

        public void setData(byte[] data)
        {
            _stream = data;
        }
        public byte[] getData() 
        {
            return _stream;
        }
    }
}
