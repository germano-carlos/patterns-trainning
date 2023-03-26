using ConsoleApp1.Factory.Example2.Entities;
using ConsoleApp1.Factory.Example2.Interfaces;

namespace ConsoleApp1.Factory.Example2.Lojas;

public class ECommerce : Creator
{
    public ECommerce(string type)
    {
        TypeName = type;
    }
    protected override ILoja CriarLoja(string? type = null)
    {
        switch (type)
        {
            case "MercadoLivre":
                return new MercadoLivre();
            case "Amazon":
                return new Amazon();
            default:
                throw new Exception("Invalid Type");
        }
    }
}