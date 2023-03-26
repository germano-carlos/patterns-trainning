using ConsoleApp1.Factory.Example1.Interfaces;

namespace ConsoleApp1.Factory.Example1.Entities;

public class Ship : ITransporte
{
    public void Deliver()
    {
        Console.WriteLine("this is a ship delivery");
    }
}