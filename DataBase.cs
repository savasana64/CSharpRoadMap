namespace StaticExample
{
    //this class is static therefore all its members are static
    //To call a method from this class only the class name is enough: you do not need to instantiate an object
    public static class DataBase
    {
        private static List<int> dbNumbers = new List<int>();

        public static void AddIndexToDB(int index)
        {
            dbNumbers.Add(index);
        }
    }
}