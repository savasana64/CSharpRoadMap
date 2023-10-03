using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    //the DviMonitor does not accept the video in VGI format
    internal class DviMonitor
    {
        private byte[] _inputStream;
        public void SetInput(DviStream inputStream)
        {
            _inputStream = inputStream.getData();
        }
    
    }
}
