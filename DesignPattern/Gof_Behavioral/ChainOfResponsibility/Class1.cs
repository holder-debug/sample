namespace DesignPattern.Gof_Behavioral.ChainOfResponsibility;

public abstract class Handler
{
    protected Handler? NextHandler;

    public void SetNext(Handler handler)
    {
        NextHandler = handler;
    }

    public abstract void Handle(int amount);
}


public class AuthenticationHandler : Handler
{
    public override void Handle(int amount)
    {
        Console.WriteLine("Authentication checked");

        NextHandler?.Handle(amount);
    }
}

public class BalanceHandler : Handler
{
    public override void Handle(int amount)
    {
        if (amount > 1000)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        Console.WriteLine("Balance checked");

        NextHandler?.Handle(amount);
    }
}


public class WithdrawalHandler : Handler
{
    public override void Handle(int amount)
    {
        Console.WriteLine("Withdrawal completed");
    }
}


public class ChainOfResponsibilityCaller
{
    public void Call()
    {
        var authentication = new AuthenticationHandler();
        var balance = new BalanceHandler();
        var withdrawal = new WithdrawalHandler();

        authentication.SetNext(balance);
        balance.SetNext(withdrawal);

        authentication.Handle(500);
    }
}