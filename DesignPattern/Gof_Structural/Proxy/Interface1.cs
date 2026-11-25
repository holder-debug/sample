namespace DesignPattern.Gof_Structural.Proxy;


public interface IUserService
{
    string GetUser(int id);
}


public class UserService : IUserService
{
    public string GetUser(int id)
    {
        Console.WriteLine("Calling external API...");

        return $"User {id}";
    }
}




public class UserServiceProxy : IUserService
{
    private readonly IUserService _service;

    private readonly Dictionary<int, string> _cache = new();

    public UserServiceProxy(IUserService service)
    {
        _service = service;
    }

    public string GetUser(int id)
    {
        if (_cache.TryGetValue(id, out var user))
        {
            Console.WriteLine("Returning from cache");

            return user;
        }

        user = _service.GetUser(id);

        _cache[id] = user;

        return user;
    }
}



public class ProxyCaller
{
    public void Call()
    {
        IUserService service = new UserServiceProxy(new UserService());
        service.GetUser(1);
    }
}