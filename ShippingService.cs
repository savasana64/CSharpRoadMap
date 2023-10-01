using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    internal class ShippingService
    {
        NotificationServiceProvider _serviceProvider;
        public ShippingService(NotificationServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void shipItem()
        {
            //code to ship the item
            _serviceProvider.GetUserNotifier().NotifyUser(1);
        }
    }
}
