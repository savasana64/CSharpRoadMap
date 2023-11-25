using System.Net.NetworkInformation;
using System.Threading.Channels;

namespace DelegateExample
{
    //delegates are used to pass a function as parameter.
    internal class DelegateExample
    {

        public delegate void stringDelegate(string s);
        static void Main(string[] args)
        {
            //we say which function our delegate is going to point to
            stringDelegate stringDelegate = ToUpperCase;

            //how to use it
            stringDelegate("This is upper case");
            stringDelegate.Invoke("This is another upper case");

            stringDelegate = ToLowerCase;

            //how to use it
            stringDelegate("This is upper case");
            stringDelegate.Invoke("This is another upper case");

            //till now we invoked the delegate now we want to pass it as a parameter:


            WriteOutput("This called from passing delgate as a parameter: ", ToLowerCase);

        }

        //we create here two methods that have the same signiture like our delegate

        static void ToUpperCase(string s) => Console.WriteLine(s.ToUpper());
        static void ToLowerCase(string s) => Console.WriteLine(s.ToLower());

        //how to pass it as a parameter
        static void WriteOutput(string s, stringDelegate stringDelegate)  
        {
            Console.WriteLine($"delegate text:  {s}");
            stringDelegate(s);
        }
    }

}