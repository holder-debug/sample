 

namespace Pa;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("start main");

        Parallel.Invoke(Operation1, Operation2);

        var task1 = Task.Run(Operation1);
        task1.Wait();

        Console.WriteLine("end main");
        Console.ReadKey();








        Console.WriteLine("start");

        Run();

        Console.WriteLine("end");
        Console.ReadKey();








        Console.WriteLine("start");

        Task.Run(() => Console.WriteLine("111111"))
            .ContinueWith(t => Console.WriteLine("222222"));

        Console.WriteLine("end");
        Console.ReadKey();
    }

    static async void Operation1()
    {
        Console.WriteLine("start Operation1");
        Console.WriteLine("end Operation1");
    }

    static async void Operation2()
    {
        Console.WriteLine("start Operation2");
        Console.WriteLine("end Operation2");
    }


    private static async Task Run()
    {
        var task = Task.Run(() =>
        {
            Thread.Sleep(5000);
            return "task 1 complete";
        });
        var result = task.Result;
        Console.WriteLine(result);
    }
    private static async Task Runner()
    {
        var task = Task.Run(() =>
        {
            Thread.Sleep(5000);
            return "task 1 complete";
        });

        Task<Task<string>> www = Task.Factory.StartNew(Test, CancellationToken.None, TaskCreationOptions.AttachedToParent, TaskScheduler.Current);

        var result = await task;
        Console.WriteLine(result);
    }

    private async static Task<string> Test()
    {
        throw new NotImplementedException();
    }
}