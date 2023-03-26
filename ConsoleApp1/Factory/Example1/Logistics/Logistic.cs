using ConsoleApp1.Factory.Example1.Interfaces;

namespace ConsoleApp1.Factory.Example1.Logistics;

public abstract class Logistic
{
    protected abstract ITransporte CreateTransport();

    private void DoSomething()
    {
        var product = CreateTransport();
        product.Deliver();
    }

    public static void StartExample()
    {
        var l = new List<Logistic>() { new RoadLogistic(), new SeaLogistic() };
        foreach (var lo in l)
            lo.DoSomething();
    }
    
}