using InterfaceSegregationPrinciple.Classes;
using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        //Regra ISP: Classes não devem ser forçadas a depender de métodos que elas não utilizam.

        static void Main(string[] args)
        {
            var impressoraHP = new ImpressoraMultifuncional();
            impressoraHP.Imprimir("Olá para todos!");
            impressoraHP.Digitalizar("Comprovante de endereço");
            impressoraHP.ImprimirFrenteVerso("Impresso ambos os lados");
            impressoraHP.EnviarFax("Por favor, enviar por e-mail da próxima vez...!");

            Console.WriteLine("");

            var impressoraEpson = new ImpressoraComum();
            impressoraEpson.Imprimir("Olá!");

            Console.ReadLine();
        }
    }
}
