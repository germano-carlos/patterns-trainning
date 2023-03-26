namespace ConsoleApp1.Factory.Example2.Interfaces;

public interface ILoja
{
    public object SearchProducts(string query);
    public object GetProduct(string id);
}