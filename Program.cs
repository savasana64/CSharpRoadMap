namespace StaticExample
{
    //The static member is callable on a class even when no instance of the class has been created.
    //It is more typical to declare a non-static class with some static members,
    //than to declare an entire class as static. Remember if a class is static all its members and functions must be static.
    //Two common uses of static fields are to keep a count of the number of objects that have been instantiated in the whole code,
    //or to store a value that must be shared among all instances.
    //Static methods can be overloaded but not overridden,
    //because they belong to the class, and not to any instance of the class.
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 100;
            DataBase.AddIndexToDB(myNumber);
        }
    }
}