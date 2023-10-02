namespace GenericMethodExample
{
    internal class GenereicEcample
    {
        static void Main(string[] args)
        {
            TestSwap();
        }
        //A way to call a generic method
        public static void TestSwap()
        {
            int a = 1;
            int b = 2;

            Swap<int>(ref a, ref b);
            System.Console.WriteLine(a + " " + b);
        }

        //You can also omit the type argument and the compiler will infer it.
        //The following call to Swap is equivalent to the previous call:
        //Swap(ref a, ref b);
        //A generic method is a method that is declared with type parameters, as follows:
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}