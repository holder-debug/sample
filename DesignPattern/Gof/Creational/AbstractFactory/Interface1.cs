namespace DesignPattern.Gof.Creational.AbstractFactory;

public interface IButton { }
public interface IRadio { }

public class WindowsButton : IButton { }
public class WindowsRadio : IRadio { }

public class LinuxButton : IButton { }
public class LinuxRadio : IRadio { }




public interface IFactory
{
    IButton CreateButton();
    IRadio CreateRadio();
}



public class WindowsFactory: IFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public IRadio CreateRadio()
    {
        return new WindowsRadio();
    }
}



public class LinuxFactory : IFactory
{
    public IButton CreateButton()
    {
        return new LinuxButton();
    }

    public IRadio CreateRadio()
    {
        return new LinuxRadio();
    }
}