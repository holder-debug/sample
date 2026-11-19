using Gof.Behavioral.Visitor;
using Gof.Other;
using Gof.Structural.Facade;
using IAnimal = Gof.Behavioral.Visitor.IAnimal;

namespace Gof;

internal class Program
{
    static void Main()
    {
        IAnimal[] animals =
        {
            new Gof.Behavioral.Visitor.Cat(),
            new Gof.Behavioral.Visitor.Dog()
        };

        IAnimalVisitor soundVisitor = new MakeSoundVisitor();
        IAnimalVisitor costVisitor = new CalculateCostVisitor();

        foreach (var animal in animals)
        {
            animal.Accept(soundVisitor);
        }

        foreach (var animal in animals)
        {
            animal.Accept(costVisitor);
        }
    }
}