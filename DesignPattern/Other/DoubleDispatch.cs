namespace DesignPattern.Other;

public interface IAnimal
{
    void Accept(AnimalService service);
}

public class Cat : IAnimal
{
    public void Accept(AnimalService service)
    {
        service.Handler(this);
    }
}

public class Dog : IAnimal
{
    public void Accept(AnimalService service)
    {
        service.Handler(this);
    }
}




public class AnimalService
{
    public void Execute(IAnimal animal)
    {
        animal.Accept(this);
    }
    public void Handler(IAnimal animal)
    {
        Console.WriteLine("animal");
    }
    public void Handler(Cat cat)
    {
        Console.WriteLine("Cat");
    }
    public void Handler(Dog dog)
    {
        Console.WriteLine("Dog");
    }
}

 