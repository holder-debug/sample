namespace DesignPattern.Gof_Structural.Adapter;

public interface ISmsService
{
    Task SendAsync(string phone, string message);  
}



public class Sms1Adapter: ISmsService
{
    private readonly Sms1 _sms1;
    public Task SendAsync(string phone, string message)
    {
        _sms1.SendSms(phone, message);
        return Task.CompletedTask;
    }
}

public class Sms2Adapter : ISmsService
{
    private readonly Sms2 _sms2;

    public Task SendAsync(string phone, string message)
    {
        _sms2.Send(phone, message);
        return Task.CompletedTask;
    }
}



public class Sms1
{
    public void SendSms(string phone, string message)
    {

    }
}


public class Sms2
{
    public void Send(string phone, string message)
    {

    }
}