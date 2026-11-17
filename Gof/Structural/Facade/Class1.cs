namespace Gof.Structural.Facade;





public class Operation
{
    private readonly serviceA _serviceA;
    private readonly serviceB _serviceB;
    private readonly serviceC _serviceC;
    private readonly serviceD _serviceD;


    public void Do()
    {
        if (!_serviceA.Check())
        {
            throw new Exception();
        }
        if (!_serviceB.Check())
        {
            throw new Exception();
        }
        if (!_serviceC.Check())
        {
            throw new Exception();
        }
        if (!_serviceD.Check())
        {
            throw new Exception();
        }
        // do operation
        
    }
}


public class serviceA
{
    public bool Check()
    {
        return true;
    }
}


public class serviceB
{
    public bool Check()
    {
        return true;
    }
}



public class serviceC
{
    public bool Check()
    {
        return true;
    }
}


public class serviceD
{
    public bool Check()
    {
        return true;
    }
}