namespace AdapterExample
{
    //use the structure or interface of an existing class with another class which is considerably different
    //morely the patters is creating a new class that adapts the other two classes
    internal class AdapterExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setting input for Dvi Monitor!");

            VgaGraphicsCard VgaGraphicsCard = new VgaGraphicsCard();
            DviMonitor DviMonitor  = new DviMonitor();

            VgaGraphicsCardAdapter VgaGraphicsCardAdapter = new VgaGraphicsCardAdapter(VgaGraphicsCard);

            DviMonitor.SetInput(VgaGraphicsCardAdapter.GetDviStream());
        }
    }
}