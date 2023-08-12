using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() 
        { 
        }

        //this is second constructor that does not inherit from the base calss
        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {

            //inherited from post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;

            //not inherited from post
            this.ImageURL = imageURL;

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUserName);
        }

    }
}
