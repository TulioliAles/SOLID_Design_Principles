using InterfaceSegregationPrinciple.Interfaces;
using System;

namespace InterfaceSegregationPrinciple.Classes
{
    public class ImpressoraMultifuncional : IImprimir, IImprimirFrenteVerso, IDigitalizar, IEnviarFax
    {
        public void Digitalizar(string conteudo)
        {
            Console.WriteLine($"Digitalizado: '{conteudo}'");
        }

        public void EnviarFax(string conteudo)
        {
            Console.WriteLine($"Fax enviado: '{conteudo}'");
        }

        public void Imprimir(string conteudo)
        {
            Console.WriteLine($"Impresso: '{conteudo}'");
        }

        public void ImprimirFrenteVerso(string conteudo)
        {
            Console.WriteLine($"Impresso frente-verso: '{conteudo}'");
        }
    }
}
