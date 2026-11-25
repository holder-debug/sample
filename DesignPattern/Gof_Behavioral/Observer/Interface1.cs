namespace DesignPattern.Gof_Behavioral.Observer;

 

public class WhatsAppGroup : IObservable<string>
{
    private readonly List<IObserver<string>> _observers = new();

    public IDisposable Subscribe(IObserver<string> observer)
    {
        _observers.Add(observer);

        return new Unsubscriber(_observers, observer);
    }

    public void SendMessage(string message)
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(message);
        }
    }

    private class Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer) : IDisposable
    {
        public void Dispose()
        {
            observers.Remove(observer);
        }
    }
}

public class WhatsAppUser(string name) : IObserver<string>
{
    public void OnNext(string message)
    {
        Console.WriteLine($"{name} received: {message}");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"{name} error: {error.Message}");
    }

    public void OnCompleted()
    {
        Console.WriteLine($"{name}: Left the group.");
    }
}




public class ObserverCaller
{
    public void Call()
    {
        var group = new WhatsAppGroup();

        var ali = new WhatsAppUser("Ali");
        var reza = new WhatsAppUser("Reza");
        var sara = new WhatsAppUser("Sara");

        var aliSubscription = group.Subscribe(ali);
        var rezaSubscription = group.Subscribe(reza);
        var saraSubscription = group.Subscribe(sara);

        group.SendMessage("Hello everyone!");

        Console.WriteLine("----------------");

        rezaSubscription.Dispose();

        group.SendMessage("How are you guys?");
    }
}