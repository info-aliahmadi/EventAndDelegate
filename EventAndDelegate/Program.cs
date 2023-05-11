// See https://aka.ms/new-console-template for more information
using EventAndDelegate;

Console.WriteLine("Start the program!");


var video = new Video()
{
    Title = "Test",
};
var videoEncoder = new VideoEncoder(); // publisher
var mailService = new MailService();
var messageService = new MessageService();

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

videoEncoder.Encode(video);