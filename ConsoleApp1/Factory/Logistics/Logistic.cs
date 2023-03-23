using ConsoleApp1.Factory.Interfaces;

namespace ConsoleApp1.Factory.Logistics;

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