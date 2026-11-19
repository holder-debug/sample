namespace DesignPattern.Gof.Creational.Builder;

public class Caller
{
    public void Call()
    {
        var sb = new StudentBuilder().WithFamily("family").WithName("name").Build();
    }
}


public class Student
{
    public string Name { get; set; }
    public string Family { get; set; }
}


public class StudentBuilder
{
    private string Name { get; set; }
    private string Family { get; set; }


    public StudentBuilder WithName(string name)
    {
        Name = name;
        return this;
    }

    public StudentBuilder WithFamily(string family)
    {
        Family = family;
        return this;
    }


    public Student Build()
    {
        return new Student()
        {
            Name = Name,
            Family = Family
        };
    }
}

