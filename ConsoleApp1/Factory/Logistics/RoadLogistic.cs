using ConsoleApp1.Factory.Entities;
using ConsoleApp1.Factory.Interfaces;

namespace ConsoleApp1.Factory.Logistics;

public class RoadLogistic : Logistic
{
    protected override ITransporte CreateTransport()
    {
        return new Truck();
    }
}