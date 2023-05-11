namespace EventAndDelegate
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending a mail..." + args.Video.Title);
        }
    }
}
