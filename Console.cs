namespace ConsoleApp1
{
    internal class Console
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a name"); //prints and moves the cursor to the next line
            string name = System.Console.ReadLine();
            System.Console.Write("The name is: {0}" , name); //prints and keeps the cursor on the same line
            System.Console.WriteLine("\n");
            System.Console.WriteLine("\n");

            System.Console.WriteLine("Enter a char"); 
            int asciValue = System.Console.Read(); //Read from Console returns the ascii value of entered the char
            System.Console.WriteLine("The ASCII value is: {0}", asciValue);

            System.Console.ReadKey(); //waits for key stroke
        }
    }
}