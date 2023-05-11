namespace EventAndDelegate
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // you can use Delegate
        /* 
         public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // or EventArgs args
         public event VideoEncodedEventHandler VideoEncoded
        */


        // or you can use EventHandler
        public event EventHandler<VideoEventArgs> VideoEncoded; // or EventArgs args if you don't want pass parameter

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
