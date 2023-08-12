namespace InterfaceExample2
{

    //there is here no relationship between car and chair to inherit from one class
    //Csharp by the way is not a multi inheritance program
    //we need an interface(contract) to get used for these classes
    internal class InterfaceExample2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Chair officeChair = new Chair("Brown", "plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            Car damagedCar = new Car(80f, "blue");


            //chair is an object of IDestroyable and can be added to destroyable list
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();


        }
    }
}