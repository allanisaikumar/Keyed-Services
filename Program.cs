using KeyedServices;
using KeyedServices.Abstract;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    // Program.cs
    public static void Main(string[] args)
    {

        var serviceProvider = new ServiceCollection()
                    .AddKeyedSingleton<ISample>("Sample1", new Sample1())
                    .AddKeyedSingleton<ISample>("Sample2", new Sample2())
                    .BuildServiceProvider();

        var sample1 = serviceProvider.GetKeyedService<ISample>("Sample1");

        var sample2 = serviceProvider.GetKeyedService<ISample>("Sample2");

        // Calling Sample 1 instance.
        sample1.Display();

        // Calling Sample 2 instance.
        sample2.Display();

        Console.ReadLine();
    }
}