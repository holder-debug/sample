using System.Collections;

namespace DesignPattern.Gof_Behavioral.Iterator;

public class UserCollection : IEnumerable<string>
{
    private readonly List<string> _users = new();

    public void Add(string user)
    {
        _users.Add(user);
    }

    public IEnumerator<string> GetEnumerator()
    {
        return _users.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


public class IteratorCaller
{
    public void Call()
    {
        var users = new UserCollection();

        users.Add("Ali");
        users.Add("Reza");
        users.Add("Sara");

        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
}