using ConsoleApp1.Factory.Interfaces;

namespace ConsoleApp1.Factory.Entities;

public class Truck : ITransporte
{
    public void Deliver()
    {
        Console.WriteLine("this is a truck delivery");
    }
}