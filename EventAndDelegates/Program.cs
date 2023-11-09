// See https://aka.ms/new-console-template for more information


using EventAndDelegates;




class Program
{
    static void Main(string[] args)
    {
        var video = new Video("MyVideo");
        var encoder = new VideoEncoder();   //publisher
        var mailService = new MailService(); //subscriber

        encoder.VideoEncoded += mailService.OnVideoEncoded;   //Subscribing the listener

        encoder.Encode(video);
    }
}

public class MailService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("Mail Service: Sending An Email ....");
    }
}