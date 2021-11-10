using InterfaceSegregationPrinciple.Interfaces;
using System;

namespace InterfaceSegregationPrinciple.Classes
{
    public class ImpressoraComum : IImprimir
    {
        public void Imprimir(string conteudo)
        {
            Console.WriteLine($"Impresso: '{conteudo}'");
        }
    }
}
