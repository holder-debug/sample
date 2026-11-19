namespace DesignPattern.Gof_Creational.FactoryMethod;


public interface INotifyFactory
{
    INotify Create();
}

public class SmsFactory : INotifyFactory
{
    public INotify Create()
    {
        return new Sms();
    }
}

public class EmailFactory : INotifyFactory
{
    public INotify Create()
    {
        return new Email();
    }
}




public interface INotify
{
    void Send();
}

public class Sms : INotify
{
    public void Send()
    {
        throw new NotImplementedException();
    }
}

public class Email : INotify
{
    public void Send()
    {
        throw new NotImplementedException();
    }
}