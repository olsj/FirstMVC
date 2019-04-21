using System;

namespace MVC
{
    public class Notification
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public Notification()
        {
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Title = "Slask" });
        }
        public class VideoEventArgs : EventArgs
        {
            public string Title { get; set; }
        }
    }
}
