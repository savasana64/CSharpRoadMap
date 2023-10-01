namespace FactoryExample
{
    //Ie. An application the informs the user that their order has been shipped
    //Imagine we do not actually want to email the user that their order has been shipped when debugging
    //but call a test function instead
    internal class FactoryExample
    {
        static void Main(string[] args)
        {
         NotificationServiceProvider notificationServiceProvider = new NotificationServiceProvider();

            var shippingService = new ShippingService(notificationServiceProvider);
            shippingService.shipItem();

            //we see that factory has encapsulated the code needed to perform 
            //the code to decide the type of notification as well as implementation of the notification 
            //is completely separate from the shipping code
        }
    }
}