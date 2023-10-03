using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    internal class TextLogger:ILogger
    {
        public void Log(string message) 
        {
            Console.WriteLine("log to a text file: " + message);
        }
    }
}
