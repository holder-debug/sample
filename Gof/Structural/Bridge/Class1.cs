namespace Gof.Structural.Bridge;

public interface IMessageSender
{
    void Send(string message);
}


public class SmsSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
}

public class EmailSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}