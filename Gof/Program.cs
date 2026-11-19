using Gof.Structural.Facade;

namespace Gof;

internal class Program
{
    static void Main()
    {
    }
}

public abstract class Animal
{
    public abstract void Accept(AnimalOperation operation);
}

public class Dog : Animal
{
    public override void Accept(AnimalOperation operation)
    {
        string fullName = this.GetType().FullName;
        operation.Execute(this);
    }
}
public class Cat : Animal
{
    public override void Accept(AnimalOperation operation)
    {
        string fullName = this.GetType().FullName;
        operation.Execute(this);
    }
}




public class AnimalOperation
{
    public void Execute(Animal animal)
    {
        Console.WriteLine("Animal operation");
    }

    public void Execute(Dog dog)
    {
        Console.WriteLine("Dog operation");
    }

    public void Execute(Cat cat)
    {
        Console.WriteLine("Cat operation");
    }
}