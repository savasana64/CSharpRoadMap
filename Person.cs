using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClassinCSharp
{
    internal class Person
    {
        //Encapsulation: making the member variables private is common practice in OOP
        private string _name;
        private int _id;
        public Person() 
        { //default constructor
            Console.WriteLine("default constructor is called");
            _name = "default"; //It is good to set values to members in default constructor
                               //when having multiple constructors
            _id = -1;
        }

        //partial specification constructor
        public Person(string name)
        {
            _name = name;
        }

        //full specification constructor
        public Person(string name, int id) 
        {
            _name = name;
            _id = id;
        }

        public void speak() 
        {
            Console.WriteLine("Hi!!!!");
        }
        //Getters and Setters
        public void setName(string name)
        {
            _name = name;
        }
        public void setId(int id)
        {
            _id = id;
        }

        public string getName()
        {
            return _name;
        }
        public int getId()
        {
            return _id;
        }

        //instead of using getters and setters we can create properties:
        //You define an auto-implemented property by using the get and set keywords
        //without providing any implementation
        //note: properties start with capital letters
        public string Name
        { get; set; }

        public decimal Id
        { get; set; }

        //expression body definitions for both accessors
        //public string Name
        //{
        //    get => _name;
        //    set => _name = value;
        //}

        //public int Id
        //{
        //    get => _id;
        //    set => _id = value;
        //}

        ~Person() //destructor (finalizer)
        { 
        }
    }
}
