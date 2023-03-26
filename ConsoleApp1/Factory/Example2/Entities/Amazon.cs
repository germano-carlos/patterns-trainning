using ConsoleApp1.Factory.Example2.Interfaces;

namespace ConsoleApp1.Factory.Example2.Entities;

public class Amazon : ILoja
{
    public object SearchProducts(string query)
    {
        Console.WriteLine("esta e uma implementacao do metodo SearchProducts na classe Amazon");
        return null;
    }

    public object GetProduct(string id)
    {
        Console.WriteLine("esta e uma implementacao do metodo GetProduct na classe Amazon");
        return null;
    }
}