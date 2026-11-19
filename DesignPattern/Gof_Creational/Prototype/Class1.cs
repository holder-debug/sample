namespace DesignPattern.Gof_Creational.Prototype;

public class Employee:ICloneable
{
    public string Name { get; set; }
    public string Family { get; set; }
    public object Clone()
    {
        return new Employee()
        {
            Name = this.Name,
            Family = this.Family,
        };
    }
}

public class Caller
{
    public void Call()
    {
        var sb = new Employee()
        {
            Name = "name",
            Family = "family",
        };


        var no =(Employee) sb.Clone();
    }
}
