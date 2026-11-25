using DesignPattern.Gof_Behavioral.ChainOfResponsibility;
using DesignPattern.Gof_Behavioral.Iterator;
using DesignPattern.Gof_Behavioral.Memento;
using DesignPattern.Gof_Behavioral.Observer;
using DesignPattern.Gof_Structural.Proxy;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
           new ObserverCaller().Call();
           new ChainOfResponsibilityCaller().Call();
           new ProxyCaller().Call();
           new IteratorCaller().Call();
           new MementoCaller().Call();
        }
    }
}
