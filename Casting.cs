namespace ImplicitAndExplicitConversions
{
    internal class Casting
    {
        static void Main(string[] args)
        {
            double d = 3.14;
            int i = 3;

            //int myInt = d; //error: no implicit conversion from int to double

            double myDouble = i; //implicit conversion
            Console.WriteLine(myDouble);

            int myInt = (int)d; //explicit conversion
            Console.WriteLine(myInt);

            //note: if we store a double into float it loses precision and gets rounded.

            Console.WriteLine(myInt); //it does not round, it cuts
            Console.Read();


            //implicit conversion works for biggger value to smaller value

            int num = 1222567765;
            long myLong = num;

            float myFloat = 13.37f;
            double myDouble2 = myFloat;

            //type conversion

            string myString = myDouble2.ToString(); //"13.37"

            Console.WriteLine("myString: " + myString);

            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);

        }
    }
}