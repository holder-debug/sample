namespace DesignPattern.Gof_Behavioral.Strategy;

public interface IShippingStrategy
{
    decimal Calculate(decimal weight);
}


public class NormalShipping : IShippingStrategy
{
    public decimal Calculate(decimal weight)
    {
        return 20000 + (weight * 5000);
    }
}

public class ExpressShipping : IShippingStrategy
{
    public decimal Calculate(decimal weight)
    {
        return 50000 + (weight * 10000);
    }
}

public class FreeShipping : IShippingStrategy
{
    public decimal Calculate(decimal weight)
    {
        return 0;
    }
}


public class ShippingCalculator
{
    private readonly IShippingStrategy _strategy;

    public ShippingCalculator(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal Calculate(decimal weight)
    {
        return _strategy.Calculate(weight);
    }
}


public class Program
{
    void Call()
    {
        IShippingStrategy s = new FreeShipping();
        ShippingCalculator c = new ShippingCalculator(s);
    }
}