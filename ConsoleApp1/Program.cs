using ConsoleApp1.Factory.Logistics;
using ConsoleApp1.Singleton;

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        Logistic.StartExample();
        SingletonClass.StartExample();
    }
}
