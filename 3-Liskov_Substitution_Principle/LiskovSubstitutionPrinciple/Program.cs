using LiskovSubstitutionPrinciple.Classes;
using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    //Regra LSP: Se 'S' é um subtipo de 'T', então objetos do tipo 'T' podem ser substituidos por objetos do tipo 'S', sem que esta
    //substituição gere efeitos colaterais na nossa aplicação.

    //Regra OCP: Objetos devem estar abertos para extensão mas, fechados para modificação.

    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> objetos = new List<Figura>();

            var objeto1 = new Retangulo();
            objeto1.SetAltura(4);
            objeto1.SetLargura(5);

            var objeto2 = new Quadrado();
            objeto2.SetTamanho(5);

            objetos.Add(objeto1);
            objetos.Add(objeto2);

            foreach (Figura figura in objetos)
            {
                Console.WriteLine($"Área do {figura.GetType().Name} é: {figura.Area()}");
            }

            Console.ReadLine();
        }
    }
}
