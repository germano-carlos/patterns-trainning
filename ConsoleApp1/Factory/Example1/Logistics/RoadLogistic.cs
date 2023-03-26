using ConsoleApp1.Factory.Example1.Entities;
using ConsoleApp1.Factory.Example1.Interfaces;

namespace ConsoleApp1.Factory.Example1.Logistics;

public class RoadLogistic : Logistic
{
    protected override ITransporte CreateTransport()
    {
        return new Truck();
    }
}