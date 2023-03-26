using System.Security.Cryptography.X509Certificates;
using ConsoleApp1.Factory.Example2.Interfaces;

namespace ConsoleApp1.Factory.Example2.Lojas;

public abstract class Creator
{
    protected string TypeName;
    protected abstract ILoja CriarLoja(string? type = null);

    public object SearchProducts(string query)
    {
        return CriarLoja(TypeName).SearchProducts(query);
    }

    public object GetProduct(string id)
    {
        return CriarLoja(TypeName).GetProduct(id);
    }

    public static void StartExampe()
    {
        var list = new List<Creator>() { new ECommerce("MercadoLivre"),new ECommerce("Amazon"), new VendasFisicas()};
        foreach (var l in list)
        {
            l.SearchProducts("teste");
            l.GetProduct("teste");
        }
    }
}