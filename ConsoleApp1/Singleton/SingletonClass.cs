namespace ConsoleApp1.Singleton;

public sealed class SingletonClass
{
    private static SingletonClass? _instance;

    private SingletonClass()
    {
        
    }

    public static SingletonClass? GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SingletonClass();
        }
        return _instance;
    }

    public static void StartExample()
    {
        SingletonClass? s1 = GetInstance();
        SingletonClass? s2 = GetInstance();

        if (s1 == s2)
        {
            Console.WriteLine("SingletonClass works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("SingletonClass failed, variables contain different instances.");
        }
    }
}