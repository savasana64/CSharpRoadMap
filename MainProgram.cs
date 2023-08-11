namespace MyFirstClassinCSharp
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Person student = new Person();
            //you can also write simpler: Person student = new();
            student.setName("Joe");
            student.speak();

            Person programmer = new Person("Mahta", 1);
            programmer.speak();

            var teacher = new Person { Name = "Mr. Smith", Id = 25 }; //this calls the default constructor

            Console.WriteLine($"{teacher.Name}: has the Id {teacher.Id}");
        }
    }
}