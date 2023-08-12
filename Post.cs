using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Post
    {

        //The static member is callable on a class even when no instance of the class has been created.
        //It is more typical to declare a non-static class with some static members,
        //than to declare an entire class as static.
        //Two common uses of static fields are to keep a count of the number of objects that have been instantiated,
        //or to store a value that must be shared among all instances.
        //Static methods can be overloaded but not overridden,
        //because they belong to the class, and not to any instance of the class.
        private static int currentPostId;


        //properties
        protected int ID { get; set; }                      //used on this class AND its derrived classes
        protected String Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        //deafult constructor
        //note: Id the derived class does not invoke the base class constructpor explicitly,
        //the default constructor is called implicitly

        public Post() 
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUserName = "Mahta Ebadi";
        }

        //Second constructor
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }

        protected int GetNextID()
        { 
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        { 
            this.Title = title;
            this.IsPublic=isPublic;
        }

        //every single class inherits from object class
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName);
        }

    }
}
