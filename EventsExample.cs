using System.Threading.Channels;

namespace EventsExample
{

    public delegate void StringDelegate(string s);


    internal class EventsExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Strings myString = new Strings();
            myString.stringEvent += TextChanged;


            string str;
            do
            {
                str = Console.ReadLine();
                if (!str.Equals("exit")) myString.Value = str;

            } while (!str.Equals("exit"));
        }

        static void TextChanged(string text) => Console.WriteLine("You entered: " + text);
    }
    

    public class Strings
    {

        private string stringValue;
        public event StringDelegate stringEvent;

        public string Value 
        {
            set 
            { 
                this.stringValue = value;
                this.stringEvent(this.stringValue);
            }
        }

        //the event is triggered whenever we set a value to this object
    }

}