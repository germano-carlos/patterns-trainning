using ConsoleApp1.Factory.Example2.Entities;
using ConsoleApp1.Factory.Example2.Interfaces;

namespace ConsoleApp1.Factory.Example2.Lojas;

public class VendasFisicas : Creator
{
    protected override ILoja CriarLoja(string? type = null)
    {
        return new Charlinhos();
    }
}