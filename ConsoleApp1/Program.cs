using ConsoleApp1.Factory.Example1.Logistics;
using ConsoleApp1.Factory.Example2.Lojas;
using ConsoleApp1.Singleton;

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        Logistic.StartExample();
        Creator.StartExampe();
        SingletonClass.StartExample();
    }
}
