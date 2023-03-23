using ConsoleApp1.Factory.Interfaces;

namespace ConsoleApp1.Factory.Entities;

public class Ship : ITransporte
{
    public void Deliver()
    {
        Console.WriteLine("this is a ship delivery");
    }
}