namespace DesignPattern.Gof_Structural.Decorator;

public interface ICoffee
{
    decimal GetCost();
    string GetDescription();
}

public class SimpleCoffee : ICoffee
{
    public decimal GetCost() => 50;

    public string GetDescription() => "Coffee";
}


public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _coffee;

    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public abstract decimal GetCost();

    public abstract string GetDescription();
}



public class MilkDecorator : CoffeeDecorator
{
    private readonly ICoffee _coffee;

    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
        _coffee = coffee;
    }

    public override decimal GetCost()
    {
        return _coffee.GetCost() + 10;
    }

    public override string GetDescription()
    {
        throw new NotImplementedException();
    }
}


public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override decimal GetCost()
        => _coffee.GetCost() + 15;

    public override string GetDescription()
        => _coffee.GetDescription() + " + Chocolate";
}


public class DecoratorCaller
{
    public void Call()
    {
        ICoffee coffee = new SimpleCoffee();
        coffee = new MilkDecorator(coffee);
    }
}