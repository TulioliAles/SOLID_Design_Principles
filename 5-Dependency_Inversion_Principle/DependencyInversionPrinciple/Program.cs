using DependencyInversionPrinciple.Classes;
using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        //Regras do DIP (Dependency Inversion Principle)
        //- Módulos de alto nível não devem depender de módulos de baixo nível, ambos deveriam depender de abstrações.
        //- Abstrações não devem depender de detalhes, porém detalhes devem depender de abstrações.

        static void Main(string[] args)
        {
            IContato cliente = Factory.GetCliente(); 
            {
                cliente.Nome = "Alessandro";
                cliente.Email = "alessandro@gmail.com";
                cliente.Celular = "16 9999-2323";
            };

            IEmail email = Factory.GetEmail();
            email.EnviarEmail(cliente, "Sobre seu saldo...", "Seu saldo está baixo.");

            IMensagemCelular sms = Factory.GetMensageiroCelular();
            sms.EnviarMensagem(cliente, "Seu saldo está baixo.");

            Console.ReadLine();
        }
    }
}
