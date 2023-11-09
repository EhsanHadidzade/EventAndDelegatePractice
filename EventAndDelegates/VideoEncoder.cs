using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    public class VideoEncoder
    {

        // 1- define a delegate
        // 2- define an event based on that delegate
        // 3- Raise the event

        //
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ....");
            Thread.Sleep(3000);


            //publishing event
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {

            //To Check Any Subscribers
            if(VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }






    }

}
