using ConsoleApp1.Factory.Entities;
using ConsoleApp1.Factory.Interfaces;

namespace ConsoleApp1.Factory.Logistics;

public class SeaLogistic : Logistic
{
    protected override ITransporte CreateTransport()
    {
        return new Ship();
    }
}