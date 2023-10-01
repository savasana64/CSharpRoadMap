using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal class EmailNotifier:IUserNotifier
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine($"Notify user {id} by email");
        }
    }
}
