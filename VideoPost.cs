using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class VideoPost : Post
    {
        //members
        protected bool playing = false;
        protected int currDuration = 0;

        Timer timer;
        //properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost()
        { 
        }
        public VideoPost(string title, string sendByUserName, string videoURL, bool isPublic, int length) 
        {

            //inherited from post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;

            //not inherited from post
            this.VideoURL = videoURL;
            this.Length = length;
        }
        //override the overriden method
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUserName);
        }

        public void play()
        {
            if (!playing)
            {
                playing = true;
                Console.WriteLine("is playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }

        }
        //playing the video runs a timer. The timer has a callback function
        //it says to the function call me back when the duration of video is over or somebody stopped the video
        private void TimerCallback(object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("video at {0} seconds", currDuration);
                GC.Collect(); //force the garbage collection

            }
            else 
            {
                stop();
            }
        }
        public void stop()
        {
            if (playing)
            {
            playing = false;
            Console.WriteLine("video stopped at {0} seconds", currDuration);
            currDuration = 0;
            timer.Dispose(); //stops the timer
            }
        }
    }
}
